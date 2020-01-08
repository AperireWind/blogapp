<template>
  <div class="home">
    <HeadNavMenu></HeadNavMenu>
    <ul>
      <li v-for="(item,i) in data"
          :key="i">
        {{item.article_Name}}
      </li>
    </ul>
  </div>
</template>

<script>
import HeadNavMenu from '@/components/HeadNavMenu.vue'
export default {
  components: {
    HeadNavMenu
  },
  data () {
    return {
      data: []
    }
  },
  mounted () {
    this.getArticles()
  },
  methods: {
    getArticles () {
      // this.$axios.get('/')
      //   .then(res => {
      //     console.log(res.data)
      //   })
      var houURL = 'https://localhost:44324'
      var url = houURL + '/api/articles/getallarticles'
      console.log(url)
      this.$axios.get(url)
        .then(res => {
          console.log(res.data)
          this.data = res.data
        })
    }
  }
}
</script>

<style lang="less" scope>
</style>
