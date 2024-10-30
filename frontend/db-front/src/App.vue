<template>
  <div>
    <nav>
      <router-link to="/">Home</router-link> |
      <router-link :to="'/suppliers/' +   getPageSupplier">Поставщики</router-link> |
      <router-link to="/warehouses">Склады</router-link> |
      <router-link to="/customers">Покупатели</router-link> |
      <router-link to="/products">Товары</router-link> |
      <router-link to="/orderlists">Заказы</router-link>
    </nav>
    <router-view/>
  </div>
</template>

<script>
import { mapGetters } from 'vuex';

export default {
    name: 'AppView',
    computed: {
      ...mapGetters('suppliers', [ 'getPageSupplier' ]),
    }
}
</script>

<style lang="scss">
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

nav {
  padding: 30px;

  a {
    font-weight: bold;
    color: #2c3e50;

    &.router-link-exact-active {
      color: #42b983;
    }
  }
}
</style>
