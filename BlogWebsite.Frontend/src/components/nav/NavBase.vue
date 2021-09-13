<template>
  <nav class="nav">
    <ul class="nav-list">
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
.nav {
  position: relative;
  top: 0;
  right: 0;
  width: 100%;
  background-color: fff;
  height: 56px;
  z-index: 100;
  font-family: 'Montserrat';
}

.nav-list{
  text-align: right;
  list-style: none;
}
</style>