<template>
  <div class="login">
    <header class="header">
      <div class="h_one">
        <van-search placeholder="请输入搜索关键词"
                    background="#1989fa00"
                    style="background-color:#1989fa00;"
                    v-model="searchValue" />
        <van-icon name="scan" />
        <van-icon name="setting-o" />
      </div>
      <div class="h_two">
        <h4 class="ht_one">登录少年，体验更多功能</h4>
        <span class="ht_two">
          <van-image round
                     width="3rem"
                     height="3rem"
                     src="https://img.yzcdn.cn/vant/cat.jpeg" />
          <van-image round
                     width="3rem"
                     height="3rem"
                     src="https://img.yzcdn.cn/vant/cat.jpeg" />
          <van-image round
                     width="3rem"
                     height="3rem"
                     src="https://img.yzcdn.cn/vant/cat.jpeg" />
        </span>
        <p class="ht_three">
          <span>其他方式登录</span>
          <van-icon name="arrow" />
        </p>
        <span class="ht_four">
          <span class="htf_one">
            <span class="htf_h">0</span>
            <span class="htf_b">关注</span>
          </span>
          <span class="htf_two"></span>
          <span class="htf_one">
            <span class="htf_h">0</span>
            <span class="htf_b">收藏夹</span>
          </span>
          <span class="htf_two"></span>
          <span class="htf_one">
            <span class="htf_h">0</span>
            <span class="htf_b">最近浏览</span>
          </span>
        </span>
      </div>
    </header>
    <div class="content">
      <div class="c_one">
        <div class="hth_item">
          <van-icon name="fire"
                    color="rgb(255, 179, 65)"
                    size="20" />
          <span class="hthi_text">社区建设</span>
        </div>
        <div class="hth_item">
          <van-icon name="flag-o"
                    color="rgb(126, 126, 126)"
                    size="20" />
          <span class="hthi_text">反馈与帮助</span>
        </div>
        <div class="hth_item">
          <van-icon name="filter-o"
                    color="rgb(77, 92, 180)"
                    size="20" />
          <span class="hthi_text">仲裁议事厅</span>
        </div>
        <div class="hth_item">
          <van-icon name="brush-o"
                    color="rgb(124, 61, 196)"
                    size="20" />
          <span class="hthi_text">夜间模式</span>
        </div>
      </div>
      <div class="mycard">
        <div class="mc_title">
          <span class="mct_card">我的卡片</span>
          <span class="mct_addCard">+ 管理卡片</span>
        </div>
        <div class="mc_body">
          <div class="mcb_title">
            <div class="mcbt_left">
              你可能感兴趣的圈子
            </div>
            <div class="mcbt_right">
              去圈子广场 >
            </div>

          </div>
          <van-swipe :width="90"
                     :loop="false"
                     :show-indicators="false"
                     class="mcb_body"
                     indicator-color="#888">
            <van-swipe-item v-for="(item,i) in allPics"
                            :key="i">
              <div slot="default">
                <div class="mcbb_item">
                  <van-image width="70"
                             height="70"
                             radius="5px"
                             :src="item.picSrc" />
                  <span class="mcbbi_text">{{item.name}}</span>
                </div>

              </div>
            </van-swipe-item>
          </van-swipe>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data () {
    return {
      searchValue: '',
      allPics: [
        { name: '王者荣耀1', picSrc: 'https://img.yzcdn.cn/vant/cat.jpeg' },
        { name: '王者荣耀2', picSrc: 'https://img.yzcdn.cn/vant/cat.jpeg' },
        { name: '王者荣耀3', picSrc: 'https://img.yzcdn.cn/vant/cat.jpeg' },
        { name: '王者荣耀4', picSrc: 'https://img.yzcdn.cn/vant/cat.jpeg' },
        { name: '王者荣耀5', picSrc: 'https://img.yzcdn.cn/vant/cat.jpeg' },
        { name: '王者荣耀6', picSrc: 'https://img.yzcdn.cn/vant/cat.jpeg' },
        { name: '王者荣耀7', picSrc: 'https://img.yzcdn.cn/vant/cat.jpeg' },
        { name: '王者荣耀8', picSrc: 'https://img.yzcdn.cn/vant/cat.jpeg' }
      ]
    }
  }
}
</script>

<style lang="less" scoped>
.login {
  .header {
    background-color: #1989fa;
    height: 200px;
    border-radius: 0 0 30px 30px;
    .h_one {
      display: flex;
      justify-content: space-between;
      align-items: center;
      .van-search {
        flex: 9;
        opacity: 0.5;
      }
      .van-icon {
        flex: 1;
        color: white;
        font-size: 22px;
      }
    }
    .h_two {
      margin: 0 0.7rem 0.7rem 0.7rem;
      background-color: #fff;
      border-radius: 10px;
      padding: 0.5rem 1rem;
      > span {
        display: flex;
        justify-content: space-around;
        align-items: center;
        font-size: 20px;
      }
      .htf_two {
        color: rgb(223, 223, 223);
        border-right: 1px solid rgb(223, 223, 223);
        height: 25px;
      }
      .ht_four {
        > span {
          display: flex;
          flex-direction: column;
          align-items: center;
          .htf_h {
            font-size: 22px;
          }
          .htf_b {
            font-size: 12px;
          }
        }
      }
      > p {
        font-size: 13px;
        color: rgb(110, 110, 110);
        display: flex;
        justify-content: center;
        align-items: center;
        border-bottom: 1px solid rgb(223, 223, 223);
        padding: 0.4rem 0;
      }
    }
  }
  .content {
    margin-top: 5.4rem;
    .c_one {
      display: flex;
      background-color: #fff;
      justify-content: space-around;
      flex-direction: row;
      .hth_item {
        display: flex;
        flex-direction: column;
        align-items: center;
        padding: 0.5rem;
        font-size: 12px;
        .van-icon {
          margin: 10px 0;
        }
        .hthi_text {
        }
      }
    }
    .mycard {
      .mc_title {
        margin: 0.6rem;
        display: flex;
        justify-content: space-between;
        align-items: center;
        .mct_card {
          font-weight: 600;
        }
        .mct_addCard {
          font-size: 14px;
          color: #1989fa;
        }
      }
      .mc_body {
        width: 100%;
        overflow: hidden;
        background-color: #fff;
        .mcb_title {
          padding: 0.6rem;
          display: flex;
          justify-content: space-between;
          .mcbt_right {
            font-size: 12px;
            color: rgb(110, 110, 110);
          }
        }
        .mcb_body {
          padding-bottom: 1rem;
          .mcbb_item {
            display: flex;
            flex-direction: column;
            justify-content: center;
            align-items: center;
            .mcbbi_text {
              font-size: 14px;
              margin-top: 0.2rem;
            }
          }
        }
      }
    }
  }
}
</style>
