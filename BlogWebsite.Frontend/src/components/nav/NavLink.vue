<template>
  <li class="nav-item">
      <a :href="url" :target="target">{{name}}</a>
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

</style>