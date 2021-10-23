<template>
  <li v-if="name" class="nav-sub-item">
      <a v-if="url" class="nav-sub-item__link" :href="url" :target="target">{{name}}</a>
      <span v-if="!url" class="nav-sub-item__link">{{name}}</span>
  </li>
</template>

<script lang="ts">
import { defineComponent } from "vue";
export default defineComponent({
  props:{
      name: String,
      url: String,
      target: String,
  },
  setup() {
  }
});
</script>

<style lang="scss">

.nav-sub-item{
    &__link{
        text-decoration: none;
        text-transform: uppercase;
        display: block;
        padding: 20px 30px;
        text-align: center;
        line-height: 1;
        white-space: nowrap;

        &:hover{
            font-weight: 600;
            text-decoration: none;
        }
    }
}

</style>