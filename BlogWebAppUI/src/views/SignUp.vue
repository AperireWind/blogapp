<template>
  <div class="home">
    <HeadNavMenu></HeadNavMenu>
    <SignUp></SignUp>
    <Footer></Footer>
  </div>
</template>

<script>
import HeadNavMenu from '@/components/HeadNavMenu.vue'
import Footer from '@/components/Footer.vue'
import SignUp from '@/components/login/SignUp.vue'

export default {
  components: {
    HeadNavMenu,
    Footer,
    SignUp
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
