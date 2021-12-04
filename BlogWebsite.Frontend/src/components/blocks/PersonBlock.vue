<template>
  <Block class="person-block">
      <img v-if="image" :src="image" :alt="name">
      <h2 v-if="name">{{name}}</h2>            
      <div v-html="text"></div>
  </Block>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import Block from "./_Block.vue";
export default defineComponent({
  props:{
      name: String,
      text: String,
      image: String,    
  },
    components: {Block}
});
</script>

<style lang="scss">
.person-block {
}
</style>