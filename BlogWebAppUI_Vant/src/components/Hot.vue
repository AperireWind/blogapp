<template>
  <div class="hot">
    <div class="hot-top">
      <van-swipe :width="65"
                 :loop="false"
                 :show-indicators="false"
                 style="width:90%;"
                 class="ht-left"
                 indicator-color="#888">
        <van-swipe-item v-for="(item,i) in types"
                        :key="i">
          <div slot="default">
            <van-button size="small"
                        type="default">{{item.name}}</van-button>
          </div>
        </van-swipe-item>
      </van-swipe>
      <van-icon class="ht-right"
                v-show="arrow_top_down"
                name="arrow-down" />
      <van-icon class="ht-right"
                v-show="!arrow_top_down"
                name="arrow-up" />
    </div>
    <div class="hot-body">
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
  </div>
</template>

<script>
export default {
  data () {
    return {
      arrow_top_down: true,
      current: 0,
      types: [
        { name: '全站' },
        { name: '科学' },
        { name: '数码' },
        { name: '体育' },
        { name: '时尚' },
        { name: '影视' }
      ],
      list: [],
      loading: false,
      finished: false,
      count: 0,
      isLoading: false
    }
  },
  methods: {
    onChange (index) {
      this.current = index
    },
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
.hot {
  padding: 1rem;
  .hot-top {
    padding: 0.1rem;
    display: flex;
    justify-content: space-between;
    align-items: center;
    .ht-right {
      margin-right: 0.5rem;
    }
  }
  .hot-body {
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
}
</style>
