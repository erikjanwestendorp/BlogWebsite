<template>
  <li class="link">
      <a :href="url">{{name}}</a>
  </li>
</template>

<script lang="ts">
import { defineComponent } from "vue";
export default defineComponent({
  props:{
      url: String,
      name: String,
  },
  setup() {
  }
});
</script>

<style lang="scss">
.default {
}
</style>