<template>
  <div class="header">
      <h1 v-if="title">{{title}}</h1>
      <img v-if="url" :src="url" :alt="alt">
  </div>
</template>
<script lang="ts">
import { defineComponent } from "vue";
export default defineComponent({

  props:{
      title: String,
      url: String,
      alt: String,
  },
  setup() {
  }
});
</script>

<style lang="scss">
.default {
}
</style>