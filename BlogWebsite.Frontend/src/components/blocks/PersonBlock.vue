<template>
  <div class="person-block">
      <img v-if="image" :src="image" :alt="name">
      <h2 v-if="name">{{name}}</h2>            
      <div v-html="text"></div>
  </div>
</template>
<script lang="ts">
import { defineComponent } from "vue";
export default defineComponent({
  props:{
      name: String,
      text: String,
      image: String,    
  }
});
</script>
<style lang="scss">
.person-block {
}
</style>