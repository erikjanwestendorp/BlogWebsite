<template>
  <nav class="nav" :class="{'menu--open': menuOpen}">
    <a v-if="homeUrl && homeName" class="nav__link" :href="homeUrl">{{homeName}}</a>
    <button class="nav__hamburger" title="menu" @click="menuOpen=!menuOpen">
      <span></span>
    </button>
    <ul class="nav__list">
      <slot></slot>
      <nav-item :name="homeName" :url="homeUrl"></nav-item>
    </ul>
  </nav>
</template>
<script lang="ts">
import { defineComponent, ref } from "vue";
export default defineComponent({
  props:{
    homeUrl: String,
    homeName: String
  },  
  setup() {
    const menuOpen = ref(false);

    return {menuOpen}
  }
});
</script>
<style lang="scss">

.nav{
  position: relative;
  @include max-bp(md){
    height: $nav-height-md;
    display: flex;
    align-items: center;
    justify-content: space-between;
    padding: 0 20px;
  }

  &__link{
    text-decoration: none;
    text-transform: uppercase;
    color: var(--blue-500);
    font-weight: 600;

    &:hover{
      text-decoration: none;
      color: var(--blue-500);
    }

        

    @include min-bp(md){
      display: none;
    }
    
  }
  &__hamburger{
    @include nav-menu-hamburger($color:var(--blue-500), $height: 19px, $width: 30px);

    @include min-bp(md){
      display: none;
    }    
  }

  &__list{
    @extend %reset-list;
    display: flex;
    justify-content: flex-end;

    .nav:not(.#{$menuOpenClass}) &{      
      @include max-bp(md){
        display: none;
      }
    }

    @include max-bp(md){
      position: absolute;
      top: $nav-height-md;
      left: 0;
      right: 0;
      background-color: var(--white-500);
      flex-direction: column;
      justify-content: flex-start;
      z-index: 200;
      height: calc(100vh - #{$nav-height-md});      
    }
  }
}

</style>