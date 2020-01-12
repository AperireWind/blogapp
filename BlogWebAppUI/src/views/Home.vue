<template>
  <div class="home">
    <HeadNavMenu></HeadNavMenu>
    <Articles></Articles>
    <Footer></Footer>
  </div>
</template>

<script>
import HeadNavMenu from '@/components/HeadNavMenu.vue'
import Footer from '@/components/Footer.vue'
import Articles from '@/components/Articles.vue'

export default {
  components: {
    HeadNavMenu,
    Footer,
    Articles
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
