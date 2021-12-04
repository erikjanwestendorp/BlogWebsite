<template>
  <Element class="image-element">
      <img v-if="image" :src="image" :alt="alt">
  </Element>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import Element from "./_Element.vue";
export default defineComponent({
  props:{
      image: String,
      alt: String
  },
  components: {Element}
});
</script>

<style lang="scss">
.image-element {
}
</style>