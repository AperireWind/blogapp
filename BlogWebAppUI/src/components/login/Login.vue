<template>
  <div class="login">
    <div class="login_left">
      <h1 class="loginName">登录</h1>
      <el-form :model="ruleForm"
               status-icon
               :rules="rules"
               ref="ruleForm"
               label-width="100px"
               class="demo-ruleForm">
        <el-form-item label="用户名"
                      prop="username">
          <el-input type="username"
                    v-model="ruleForm.username"
                    autocomplete="off"></el-input>
        </el-form-item>
        <el-form-item label="密码"
                      prop="pass">
          <el-input type="password"
                    v-model="ruleForm.pass"
                    autocomplete="off"></el-input>
        </el-form-item>
        <div class="yzm">
          验证码
        </div>
        <el-form-item>
          <el-button type="primary"
                     style="width:100%;"
                     @click="submitForm('ruleForm')">登 录</el-button>
        </el-form-item>
      </el-form>
    </div>
    <div class="login_right">
      <p>
        还不是本站的用户？
      </p>
      <p>
        马上注册，掌握一手资讯。
      </p>
      <p>
        <router-link to="/signup">
          <el-link type="primary">免费注册</el-link>
        </router-link>
      </p>

    </div>
  </div>

</template>

<script>

export default {
  data () {
    var checkAge = (rule, value, callback) => {
      if (!value) {
        return callback(new Error('年龄不能为空'))
      }
      setTimeout(() => {
        if (!Number.isInteger(value)) {
          callback(new Error('请输入数字值'))
        } else {
          if (value < 18) {
            callback(new Error('必须年满18岁'))
          } else {
            callback()
          }
        }
      }, 1000)
    }
    var validatePass = (rule, value, callback) => {
      if (value === '') {
        callback(new Error('请输入密码'))
      } else {
        if (this.ruleForm.checkPass !== '') {
          this.$refs.ruleForm.validateField('checkPass')
        }
        callback()
      }
    }
    var validatePass2 = (rule, value, callback) => {
      if (value === '') {
        callback(new Error('请再次输入密码'))
      } else if (value !== this.ruleForm.pass) {
        callback(new Error('两次输入密码不一致!'))
      } else {
        callback()
      }
    }
    return {
      login: true,
      ruleForm: {
        pass: '',
        checkPass: '',
        age: ''
      },
      user: {
        userName: '张三',
        userPwd: '123'
      },
      rules: {
        pass: [
          { validator: validatePass, trigger: 'blur' }
        ],
        checkPass: [
          { validator: validatePass2, trigger: 'blur' }
        ],
        age: [
          { validator: checkAge, trigger: 'blur' }
        ]
      }
    }
  },
  methods: {
    submitForm (formName) {
      this.$refs[formName].validate((valid) => {
        if (valid) {
          alert('submit!')
        } else {
          console.log('error submit!!')
          return false
        }
      })
    },
    resetForm (formName) {
      this.$refs[formName].resetFields()
    }
  }
}
</script>

<style lang="less" scope>
// @import url("./Home.less");
.login {
  width: 60%;
  margin: 0.5rem 20% 0 20%;
  height: 100%;
  display: flex;
  align-items: center;
  .login_left {
    display: block;
    width: 50%;
    padding: 5%;
    margin-bottom: 0.5rem;
    .loginName {
      padding: 5%;
    }
  }
  .login_right {
    display: block;
    width: 50%;
    color: #5a6169;
    font-size: 14px;
    > p {
      margin-bottom: 10px;
    }
  }
}
</style>
