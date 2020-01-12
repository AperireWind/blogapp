<template>
  <div class="head_menu">
    <div class="menu_center">
      <span class="logo">
        <img src="@/common/images/logo.png"
             alt="">
      </span>
      <router-link to="/">
        <el-link :underline="false"
                 class="index">首页</el-link>
      </router-link>

      <span class="search">
        <el-input placeholder="请输入内容"
                  prefix-icon="el-icon-search"
                  v-model="value">
        </el-input>
      </span>
      <span class="login_signup"
            v-show="!isLogin">
        <router-link to="/login">
          <el-button type="primary"
                     style="margin-right:0.1rem;"
                     plain>登录</el-button>
        </router-link>

        <router-link to="/signup">
          <el-button type="primary"
                     plain>注册</el-button>
        </router-link>

      </span>
      <span class="mine_write"
            v-show="isLogin">
        <router-link to="/personal">
          <el-dropdown>
            <el-button type=""
                       class="el-icon-user"
                       circle></el-button>
            <el-dropdown-menu slot="dropdown">
              <el-dropdown-item>个人主页</el-dropdown-item>
              <el-dropdown-item>个人资料</el-dropdown-item>
            </el-dropdown-menu>
          </el-dropdown>
        </router-link>
        <router-link to="/personal">
          <el-button type="primary"
                     style="margin-left:0.1rem;"
                     plain
                     round>写文章</el-button>
        </router-link>

      </span>
    </div>
  </div>
</template>
<script>

export default {
  data () {
    return {
      value: '',
      isLogin: false
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
    width: 75%;
    height: 60px;
    line-height: 60px;
    margin: 0 12.5% 0 12.5%;
    .logo {
      float: left;
      > img {
        height: 46px;
      }
    }
    .index {
      float: left;
      margin: 0 0.2rem 0 0.5rem;
    }
    .search {
      float: left;
      width: 30%;
    }
    .login_signup {
      float: right;
    }
    .mine_write {
      float: right;
    }
  }
}
</style>
