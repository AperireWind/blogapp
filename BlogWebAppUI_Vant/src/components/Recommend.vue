<template>
  <div class="recommend">
    <van-pull-refresh v-model="isLoading"
                      @refresh="onRefresh">
      <van-list v-model="loading"
                :finished="finished"
                finished-text="没有更多了"
                @load="onLoad">
        <van-cell v-for="item in list"
                  :key="item">
          <template slot="title">
            <p class="custom-title"
               style="text-align:left;">
              这里是标题?
            </p>
          </template>
          <template slot="label">
            <span class="custom-label">
              <p class="top"
                 style="text-align:left;">
                <van-image round
                           width="1.5rem"
                           height="1.5rem"
                           src="https://img.yzcdn.cn/vant/cat.jpeg" />
                <span class="userName">天才</span>
                <span>活到老 学到老</span>
              </p>
              <p class="middle">
                1、这里是具体的内容简介
                2、这里是具体的内容简介
              </p>
              <p class="bottom"
                 style="text-align:left;">
                <span>200 赞同 . 790 评论</span>
              </p>
            </span>
          </template>
        </van-cell>
      </van-list>
    </van-pull-refresh>

  </div>
</template>

<script>
export default {
  data () {
    return {
      list: [],
      loading: false,
      finished: false,
      count: 0,
      isLoading: false
    }
  },

  methods: {
    onLoad () {
      // 异步更新数据
      setTimeout(() => {
        for (let i = 0; i < 10; i++) {
          this.list.push(this.list.length + 1)
        }
        // 加载状态结束
        this.loading = false

        // 数据全部加载完成
        if (this.list.length >= 40) {
          this.finished = true
        }
      }, 500)
    },
    onRefresh () {
      setTimeout(() => {
        this.$toast('刷新成功')
        this.isLoading = false
        this.count++
      }, 1000)
    }
  }
}
</script>

<style lang="less" scoped>
.recommend {
  margin-bottom: 8vh;
  .custom-label {
    .top {
      display: flex;
      align-items: center;
      .userName {
        margin: 0 0.3rem;
        color: black;
      }
    }
    .middle {
      text-align: left;
      color: black;
    }
  }
}
</style>
