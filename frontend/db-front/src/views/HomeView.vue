<template>
  <div class="home">
    <img alt="Vue logo" src="../assets/warehouse_logo.png">
    <HelloWorld msg="Warehouse Product Management Software"/>
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
  margin-top: 80px;
  width: 200px;
}
</style>
