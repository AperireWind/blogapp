<template>
  <div class="guanzhu">
    <div class="gzTitle">最常访问</div>
    <div class="gzItemList">
      <div class="gzItem">
        <van-image fit="cover"
                   round
                   width="3rem"
                   height="3rem"
                   src="https://img.yzcdn.cn/vant/cat.jpeg" />
        <p class="gzi-text">.NET Core</p>
      </div>
      <div class="gzItem">
        <van-icon name="plus"
                  class="gzi-add" />

        <p class="gzi-text">关注更多</p>
      </div>
    </div>
  </div>
</template>

<script>
export default {

}
</script>

<style lang="less" scoped>
.guanzhu {
  padding: 1rem;
  .gzTitle {
    text-align: left;
    font-size: 12px;
    color: rgb(150, 150, 150);
  }
  .gzItemList {
    text-align: left;
    margin-top: 0.5rem;
    display: flex;
    justify-content: flex-start;
    margin-right: 10px;
    .gzItem {
      width: 3rem;
      margin-right: 1rem;
      .van-image {
      }
      .gzi-text {
        margin: 5px 0;
        width: 3rem;
        font-size: 12px;
        display: -webkit-box;
        -webkit-box-orient: vertical;
        -webkit-line-clamp: 1;
        overflow: hidden;
        height: 12px;
        line-height: 12px;
      }
      .gzi-add {
        width: 100%;
        height: 3rem;
        border-radius: 50%;
        border: 1px dashed rgb(161, 161, 161);
        color: rgb(161, 161, 161);
        text-align: center;
        line-height: 3rem;
        font-size: 24px;
        margin-bottom: 2px;
      }
    }
  }
}
</style>
