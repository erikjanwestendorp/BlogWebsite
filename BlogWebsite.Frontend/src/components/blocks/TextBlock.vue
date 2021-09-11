<template>
  <div class="default">
      {{title}}
      <slot></slot>      
      <a v-if="link" :href="link">{{title}}</a>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";
export default defineComponent({
  props:{
      title: String,
      link: String
  }
});
</script>

<style lang="scss">
.default {
}
</style>