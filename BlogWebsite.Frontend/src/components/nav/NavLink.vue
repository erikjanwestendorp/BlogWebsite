<template>
  <li class="nav-item">
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
.nav-item {
  float: right;
  padding: 0;
  margin-left: 20px;
  text-transform: uppercase;
}
</style>