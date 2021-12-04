<template>
  <Block class="images-block">
      <slot></slot>
  </Block>
</template>
<script lang="ts">
import { defineComponent } from "vue";
import Block from "./_Block.vue";

export default defineComponent({
    components: {Block}

});
</script>
<style lang="scss">
.images-block {
}
</style>