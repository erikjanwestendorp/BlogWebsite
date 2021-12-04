<template>
  <div class="text-block">
      <h2 v-if="title">{{title}}</h2>            
      <div v-html="text"></div>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";
export default defineComponent({
  props:{
      title: String,
      text: String
  }
});
</script>

<style lang="scss">
.text-block {
}
</style>