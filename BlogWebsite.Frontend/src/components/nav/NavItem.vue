<template>
  <li v-if="name" class="nav-item">
      <a v-if="url" class="nav-item__link" :href="url" :target="target">{{name}}</a>
      <span v-if="!url" @click="subMenuOpen=!subMenuOpen" class="nav-item__link">{{name}}</span>
      <ul v-if="hasContent" class="nav-item__list" :class="{'submenu--open':subMenuOpen}">
        <slot></slot>
      </ul>
  </li>
</template>

<script lang="ts">
import { computed, defineComponent, ref } from "vue";
export default defineComponent({
  props:{
      name: String,
      url: String,
      target: String,
  },
  setup(props, {slots}) {
    const hasContent = computed(() => !!slots.default);
    const subMenuOpen = ref(false);

    return {hasContent, subMenuOpen}

  }
});
</script>

<style lang="scss">

.nav-item{
  position: relative;
   
  &:last-child{
    color: var(--white-500);
    background-color: var(--green-500);
     @include max-bp(md){
       display: none;
     }
  }

  &__link{
    text-decoration: none;
    text-transform: uppercase;
    display: block;
    padding: 20px 30px;
    line-height: 1;
    text-align: center;

    &:hover{
      font-weight: 600;
      text-decoration: none;
    }    
  }

  &__list{
    @extend %reset-list;
    border: 1px solid var(--yellow-500);    
    transition: all $transition-properties;
    background-color: var(--white-500);

    @include min-bp(md){
      position: absolute;
      top: 100%;
      left: 50%;
      transform: translateX( -50%);
      min-width: 180px;
      box-shadow: 0 5px 20px -8px rgba($color: var(--black-500-rgb), $alpha: 0.2);

    }
    
    
    &:not(.submenu--open){
      @include max-bp(md){
        display: none;
      }      
    }

    .nav-item:not(:hover) &{
      opacity: 0;
      visibility: hidden;
      margin-top: -10px;
    }    
  }
}

</style>