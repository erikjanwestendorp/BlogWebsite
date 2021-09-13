<template>
  <div class="header">
      <h1 v-if="title">{{title}}</h1>
      <img v-if="imageUrl" :src="imageUrl" :alt="imageAlt">
  </div>
</template>
<script lang="ts">
import { defineComponent } from "vue";
export default defineComponent({

  props:{
      title: String,
      imageUrl: String,
      imageAlt: String,
  },
  setup() {
  }
});
</script>

<style lang="scss">
.header {
}
</style>
