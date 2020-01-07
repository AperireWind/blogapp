<template>
  <div class="head_menu">
    <div class="menu_center">
      <span class="logo">
        <img src="@/common/images/logo.png"
             alt="">
      </span>
      <span class="index">首页</span>
      <span class="search">
        <el-input placeholder="请输入内容"
                  prefix-icon="el-icon-search"
                  style="width:10%;"
                  v-model="value">
        </el-input>
      </span>
      <span class="login_signup">
        <el-button type="primary"
                   plain>登录</el-button>
        <el-button type="primary"
                   plain>注册</el-button>
      </span>
      <span class="mine_write">
        <el-button type="primary">个人中心</el-button>
        <el-button type="primary"
                   round>写文章</el-button>
      </span>
    </div>
  </div>
</template>
<script>
export default {
  data () {
    return {
      value: 0
    }
  },
  methods: {
  }
}
</script>

<style lang="less" scope>
.head_menu {
  width: 100%;
  height: 60px;
  border-bottom: 1px solid #edf0f4;
  background: white;
  .menu_center {
    .logo {
      > img {
        height: 46px;
      }
    }
  }
}
</style>
