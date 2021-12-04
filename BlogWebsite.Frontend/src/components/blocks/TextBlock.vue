<template>
  <div class="default">
      <h2 v-if="title">{{title}}</h2>            
      <div v-html="text"></div>
      <!-- <a class="button" v-if="link" :href="link">{{linkTitle}}</a> -->
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
.default {
}
</style>