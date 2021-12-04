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
    @each $color,$value in $colors {
        .text-block.title--#{$color} & {
          color: $value; 
        }
    }    
  }
  &__text{
    ul,ol{
      @each $color,$value in $colors {
        .text-block.list--#{$color} & {
          color: $value; 
        }
      }
    }
    a{
       @each $color,$value in $colors {
        .text-block.link--#{$color} & {
          color: $value; 
        }
      }
    }
  }  
}
</style>