<template>
  <nav class="nav">
    <ul class="nav__list">
      <slot></slot>
    </ul>
  </nav>
</template>
<script lang="ts">
import { defineComponent } from "vue";
export default defineComponent({
    setup() {
  }
});
</script>
<style lang="scss">

.nav{
  &__list{
    @extend %reset-list;
    display: flex;
    justify-content: flex-end;
  }
}

</style>