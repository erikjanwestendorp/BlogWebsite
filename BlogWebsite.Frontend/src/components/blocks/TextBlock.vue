<template>
  <div class="default">
      <h2 v-if="title">{{title}}</h2>
      <slot></slot>      
      <a v-if="link" :href="link">{{linkTitle}}</a>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";
export default defineComponent({
  props:{
      title: String,
      link: String,
      linkTitle: String,
  }
});
</script>

<style lang="scss">
.default {
}
</style>