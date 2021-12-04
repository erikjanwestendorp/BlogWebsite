<template>
  <Block class="video-block">
      <iframe v-if="external" :src="url"></iframe>
      <video v-if="!external" :src="url"></video>
      <img v-if="placeholder" :src="placeholder" :alt="placeholderAlt">
  </Block>
</template>
<script lang="ts">
import { defineComponent } from "vue";
import Block from "./_Block.vue";
export default defineComponent({
  props:{
      external: Boolean,
      url: String,
      placeholder: String,
      placeholderAlt : String
  },
  components: {Block}
});
</script>
<style lang="scss">
.video-block {
}
</style>