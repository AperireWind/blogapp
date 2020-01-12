<template>
  <div class="signup">
    <div class="signup_left">
      <h1 class="signupName">注册</h1>
      <el-form :model="ruleForm"
               status-icon
               :rules="rules"
               ref="ruleForm"
               label-width="100px"
               class="demo-ruleForm">
        <el-form-item label="用户名"
                      placeholder="请输入用户名"
                      prop="username">
          <el-input type="username"
                    v-model="ruleForm.username"
                    autocomplete="off"></el-input>
        </el-form-item>
        <el-form-item label="密码"
                      placeholder="请输密码"
                      prop="pass">
          <el-input type="password"
                    v-model="ruleForm.pass"
                    autocomplete="off"></el-input>
        </el-form-item>
        <el-form-item label="确认密码"
                      placeholder="请再次输入密码"
                      prop="checkPass">
          <el-input type="password"
                    v-model="ruleForm.checkPass"
                    autocomplete="off"></el-input>
        </el-form-item>
        <div>
          验证码
        </div>
        <el-form-item>
          <el-button type="primary"
                     @click="submitForm('ruleForm')">提交</el-button>
          <el-button @click="resetForm('ruleForm')">重置</el-button>
        </el-form-item>
      </el-form>
    </div>
    <div class="signup_right">
      <p>
        请妥善保存您本站的账号及登录密码。
      </p>
      <p>
        请勿和其他网站使用相同的登录密码。
      </p>
      <p>
        已有账号？去
        <router-link to="/login">
          <el-link type="primary">登录</el-link>
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
      ruleForm: {
        pass: '',
        checkPass: '',
        age: ''
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
.signup,
.login {
  width: 60%;
  margin: 0.5rem 20% 0 20%;
  height: 100%;
  display: flex;
  align-items: center;
  .signup_left {
    display: block;
    width: 50%;
    padding: 5%;
    margin-bottom: 0.5rem;
    .signupName {
      padding: 5%;
    }
  }
  .signup_right {
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
