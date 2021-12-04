<template>
  <Block class="link-block">
      <a class="button" v-if="link" :href="link">{{title}}</a>
  </Block>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import Block from "./_Block.vue";
export default defineComponent({
  props:{
      title: String,
      link: String
  },
  components: {Block}

});
</script>

<style lang="scss">
.link-block {
}
</style>