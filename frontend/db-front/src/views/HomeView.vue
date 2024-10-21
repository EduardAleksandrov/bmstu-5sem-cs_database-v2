<template>
  <div class="home">
    <img alt="Vue logo" src="../assets/warehouse_logo.png">
    <HelloWorld msg="Warehouse Order Management Software"/>
  </div>
</template>

<script>
// @ is an alias to /src
import HelloWorld from '@/components/HelloWorld.vue'

export default {
  name: 'HomeView',
  components: {
    HelloWorld
  }
}
</script>

<style lang="scss">
img{
  width: 200px;
}
</style>
