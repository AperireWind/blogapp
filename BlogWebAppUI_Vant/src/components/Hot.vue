<template>
  <div class="hot">
    <div class="hot-top">
      <van-swipe :width="65"
                 :loop="false"
                 :show-indicators="false"
                 style="width:90%;"
                 class="ht-left"
                 indicator-color="#888">
        <van-swipe-item>
          <div slot="default">
            <van-button size="small"
                        type="default">全站</van-button>
          </div>
        </van-swipe-item>
        <van-swipe-item v-for="(item,i) in allListTypes"
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
      <div class="hot-show"
           @click.stop
           v-show="!arrow_top_down">
        <div class="ht-one">
          <div class="ht-left">
            全部榜单
          </div>
          <van-icon class="ht-right"
                    @click="arrow_top_down=true"
                    name="arrow-up" />
        </div>
        <div class="ht-two">
          <van-panel>
            <template slot="header">
              <div class="htt-header">
                <div class="htth-left">
                  <span class="title">我的榜单</span>
                  <span class="miaoshu">长按拖拽排序</span>
                </div>
                <div class="htth-right">
                  <van-button round
                              type="info"
                              size="mini"
                              v-show="allListIsEdit"
                              @click="allListEdit()"
                              plain>编辑</van-button>
                  <van-button round
                              type="info"
                              size="mini"
                              v-show="!allListIsEdit"
                              @click="finishAllList()"
                              plain>完成</van-button>
                </div>
              </div>
            </template>
            <template slot="default">
              <div class="htth-content">
                <van-tag size="large"
                         color="rgb(245, 245, 245)"
                         text-color="#000"
                         style="margin:0.3rem;padding: 8px 27px;">
                  全站
                </van-tag>
                <van-tag v-for="(item,i) in allListTypes"
                         size="large"
                         color="rgb(245, 245, 245)"
                         text-color="#000"
                         style="margin:0.3rem;padding: 8px 27px;"
                         :key="i">
                  {{item.name}}
                  <van-icon name="cross"
                            v-show="!allListIsEdit"
                            class="hca-close" />
                </van-tag>
              </div>

            </template>
          </van-panel>
          <van-panel>
            <template slot="header">
              <div class="htt-header">
                <div class="htth-left">
                  <span class="title">推荐榜单</span>
                  <span class="miaoshu">点击添加榜单</span>
                </div>

              </div>
            </template>
            <template slot="default">
              <div class="htth-content">
                <van-tag v-for="(item,i) in recommendListTypes"
                         size="large"
                         color="rgb(245, 245, 245)"
                         text-color="#000"
                         style="margin:0.3rem;padding: 8px 15px;"
                         :key="i">
                  <van-icon name="plus"
                            style="margin-right:10px;" />
                  {{item.name}}
                </van-tag>
              </div>

            </template>
          </van-panel>
        </div>

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
      allListTypes: [
        { name: '科学' },
        { name: '数码' },
        { name: '体育' },
        { name: '时尚' },
        { name: '影视' }
      ],
      recommendListTypes: [
        { name: '校园' },
        { name: '汽车' }
      ],
      list: [],
      loading: false,
      finished: false,
      count: 0,
      isLoading: false,
      activeName: ['1'],
      allListIsEdit: true
    }
  },
  methods: {
    allListEdit () {
      this.allListIsEdit = false
    },
    finishAllList () {
      this.allListIsEdit = true
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
    background-color: rgb(255, 255, 255);
    border-radius: 0 0 10px 10px;
    padding: 20px;
    .ht-one {
      display: flex;
      justify-content: space-between;
      .ht-left {
        font-weight: 600;
      }
      .ht-right {
        margin-right: 0.4rem;
      }
    }
    .ht-two {
      .van-panel {
        .htt-header {
          display: flex;
          justify-content: space-between;
          padding: 10px 0;
          .htth-left {
            .title {
            }
            .miaoshu {
              font-size: 12px;
              margin-left: 10px;
              color: rgb(150, 150, 150);
            }
          }
          .htth-right {
          }
        }
      }
      .htth-content {
        text-align: left;
        .van-tag {
          position: relative;
          .hca-close {
            position: absolute;
            top: -0.2rem;
            right: -0.2rem;
            border-radius: 50%;
            background-color: pink;
            font-size: 12px;
            padding: 2px;
            color: white;
            background-color: rgb(172, 172, 172);
          }
        }
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
