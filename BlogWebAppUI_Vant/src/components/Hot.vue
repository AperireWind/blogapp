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
                @click="arrow_top_down=false"
                name="arrow-down" />
    </div>
    <van-overlay :show="!arrow_top_down"
                 z-index="999"
                 @click="arrow_top_down = true">
      888
      <div class="hot-show"
           @click.stop
           v-show="!arrow_top_down">
        <div class="ht-left">
          全部榜单
        </div>
        <van-icon class="ht-right"
                  @click="arrow_top_down=true"
                  name="arrow-up" />
      </div>
      
    </van-overlay>

    <div class="hot-body">
      <van-pull-refresh v-model="isLoading"
                        @refresh="onRefresh">
        <van-list v-model="loading"
                  :finished="finished"
                  finished-text="没有更多了"
                  @load="onLoad">
          <van-cell v-for="(item,i) in list"
                    class="hbl_item"
                    :key="i">
            <template slot="title">
              <p class="custom-title"
                 style="text-align:left;">
                这里是标题?
              </p>
            </template>
            <template slot="label">
              <div class="custom-label">
                <span style="font-size:20px;font-weight:700;"> {{i}} </span>
                <span style="margin: 0 0.5rem;">
                  <p class="middle">
                    1、这里是具体的内容简介
                    2、这里是具体的内容简介
                  </p>
                  <p class="bottom"
                     style="text-align:left;">
                    <span>200 赞同 . 790 评论</span>
                  </p>
                </span>
                <span>
                  <van-image width="8rem"
                             height="6rem"
                             radius="0.3rem"
                             src="https://img.yzcdn.cn/vant/cat.jpeg" />
                </span>
              </div>

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
      isLoading: false,
      activeName: ['1']
    }
  },
  methods: {
    a () {
      this.show = true
    },
    b () {
      this.show = false
    },
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
//解决van-overlay无法正常使用
::v-deep .van-overlay {
  position: absolute;
}
.hot {
  padding: 1rem;
  position: relative;
  .hot-top {
    padding: 0.1rem;
    display: flex;
    justify-content: space-between;
    align-items: center;
    .ht-right {
      margin-right: 0.5rem;
    }
  }
  .hot-show {
    position: absolute;
    z-index: 555;
    top: 0;
    left: 0;
    width: 100vw;
    background-color: rgb(189, 189, 189);
    .hts-bgc {
      width: 100vw;
      height: 100vh;
      // background-color: rgba(0, 0, 0, 0.329);
      z-index: 996;
      position: fixed;
    }
    .hts-body {
      margin: 1rem;
      display: flex;
      justify-content: space-between;
      align-items: center;
      .ht-left {
        width: 90%;
        text-align: left;
      }
      .ht-right {
        width: 10%;
      }
    }
  }
  .hot-body {
    margin-bottom: 8vh;
    .custom-label {
      display: flex;
      flex-direction: row;
      align-items: flex-start;
      justify-content: space-between;
      > span {
        .middle {
          text-align: left;
          color: black;
          margin-top: 0;
        }
      }
    }
  }
}
</style>
