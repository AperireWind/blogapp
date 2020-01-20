<template>
  <div class="home">
    <div class="top">
      <van-icon name="music-o"
                color="#1989fa"
                style="width:10%;"
                size="25" />
      <van-search placeholder="请输入搜索关键词"
                  style="width:70%;"
                  v-model="searchValue" />
      <van-icon name="sign"
                style="width:10%;"
                size="25" />
    </div>

    <van-tabs v-model="activedHT"
              animated
              color="#888"
              line-height="2px"
              sticky>
      <van-tab title="关注">
        <div slot="title">
          关注
          <van-icon name="arrow-down"
                    :class="{ whiteColor:activedHT!==0 }" />
        </div>
        <GuanZhu></GuanZhu>
      </van-tab>
      <van-tab title="推荐">
        <div slot="title">
          推荐
          <van-icon name="arrow-down"
                    :class="{ whiteColor:activedHT!==1 }" />
        </div>
        <Recommend></Recommend>
      </van-tab>
      <van-tab title="热榜">
        <div slot="title">
          热榜
          <van-icon name="arrow-down"
                    :class="{ whiteColor:activedHT!==2 }" />
        </div>
        <Hot></Hot>
      </van-tab>
    </van-tabs>
  </div>
</template>

<script>
// @ is an alias to /src
import Recommend from '@/components/Recommend.vue'
import Hot from '@/components/Hot.vue'
import GuanZhu from '@/components/GuanZhu.vue'

export default {
  name: 'home',
  components: {
    Recommend,
    Hot,
    GuanZhu
  },
  data () {
    return {
      activedHT: 2,
      searchValue: '',
      homeTop: [
        {
          name: '关注',
          value: 'guanzhu'
        },
        {
          name: '推荐',
          value: 'tuijian'
        },
        {
          name: '热榜',
          value: 'rebang'
        }
      ]
    }
  },
  methods: {

  }
}
</script>

<style lang="less" scoped>
.whiteColor {
  color: white;
}
.home {
  .top {
    display: flex;
    justify-content: space-around;
    align-items: center;
    padding: 0 0.5rem;
  }
}
</style>
