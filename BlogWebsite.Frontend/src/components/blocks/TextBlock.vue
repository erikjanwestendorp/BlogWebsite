<template>
  <Block class="text-block">
      <h2 v-if="title">{{title}}</h2>            
      <div v-html="text"></div>
  </Block>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import Block from "./_Block.vue";
export default defineComponent({
  props:{
      title: String,
      text: String
  },
  components: {Block}
});
</script>

<style lang="scss">
.text-block {
}
</style>