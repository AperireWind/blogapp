<template>
  <div class="home">
    <HeadNavMenu></HeadNavMenu>
    <Login></Login>
    <Footer></Footer>
  </div>
</template>

<script>
import HeadNavMenu from '@/components/HeadNavMenu.vue'
import Footer from '@/components/Footer.vue'
import Login from '@/components/login/Login.vue'

export default {
  components: {
    HeadNavMenu,
    Footer,
    Login
  },
  data () {
    return {
    }
  },
  mounted () {
  },
  methods: {

  }
}
</script>

<style lang="less" scope>
// @import url("./Home.less");
.home {
  width: 100%;

  .footer {
  }
}
</style>
