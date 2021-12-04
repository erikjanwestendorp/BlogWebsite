<template>
  <Block class="text-block" 
    :class="[
      colors.titleColor ? 'title--' + colors.titleColor : '', 
      colors.listColor ? 'list--' + colors.listColor : '', 
      colors.linkColor ? 'link--' + colors.linkColor : '']">
    <div class="container">
      <h2 v-if="title" class="text-block__title">{{title}}</h2>            
      <div v-html="text" class="text-block__text"></div>
    </div>      
  </Block>
</template>

<script lang="ts">
import { defineComponent, PropType } from "vue";
import Block from "./_Block.vue";
import {ThemeColors} from "../../types/theme-colors";

export default defineComponent({
  props:{
      title: String,
      text: String,
      colors: Object as PropType<ThemeColors>

  },
  components: {Block}  
});
</script>

<style lang="scss">
.text-block {
  &__title{
    margin-bottom: 20px;
    .text-block.title--blue & {
        color: var(--blue-500);
      }
  }
  &__text{
    ul,ol{
      .text-block.list--blue & {
        color: var(--blue-500);
      }
    }
    a{
      .text-block.link--blue &{
        color: var(--blue-500);
      }
    }
  }  
}
</style>