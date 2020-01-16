<template>
  <div id="app">
    <div id="nav">
      <router-link to="/">
        <div class="home">
          <van-icon name="wap-home-o"
                    size="25"
                    color="#000" />
          <span style="font-size: 10px;">首页</span>
        </div>

      </router-link>
      <router-link to="/vip">
        <div class="vip">
          <van-icon name="vip-card-o"
                    size="25"
                    color="#000" />
          <span style="font-size: 10px;">会员</span>
        </div>

      </router-link>
      <router-link to="/add">
        <van-icon name="add-o"
                  size="40"
                  color="#1989fa" />
      </router-link>
      <router-link to="/notice">
        <div class="notice">
          <van-icon name="chat-o"
                    size="25"
                    dot
                    color="#000" />
          <span style="font-size: 10px;">通知</span>
        </div>

      </router-link>
      <router-link to="/mine">
        <div class="mine">
          <van-icon name="contact"
                    size="25"
                    color="#000" />
          <span style="font-size: 10px;">我的</span>
        </div>

      </router-link>
    </div>
    <router-view />
  </div>
</template>

<style lang="less">
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #000000;
  width: 100vw;
  height: 100vh;
}

#nav {
  width: 100vw;
  height: 8vh;
  // background-color: rgb(192, 192, 192);
  box-shadow: 0 2px 4px rgba(0, 0, 0, 0.12);
  position: fixed;
  bottom: 0;
  display: flex;
  flex-direction: row;
  justify-content: space-around;
  align-items: center;
  a {
    font-weight: bold;
    color: #2c3e50;
    font-size: 14px;
    > div {
      display: flex;
      flex-direction: column;
      justify-content: space-between;
      font-size: 14px;
    }

    &.router-link-exact-active {
      color: #42b983;
    }
  }
}
</style>
