<template>
  <div class="articles">
    <el-row type="flex"
            justify="center">
      <el-col :span="18">
        <el-tabs v-model="activeName"
                 tab-position="left"
                 style="margin:0.2rem 0 0.2rem 0;"
                 type="card"
                 @tab-click="handleClick">
          <el-tab-pane label="最新文章"
                       name="newArticles">
            <div v-for="(item,i) in articles"
                 :key="i">
              <div class="na_top">
                <el-button type=""
                           class="el-icon-user nat_left"
                           circle>
                </el-button>
                <span class="nat_right">
                  <span class="user">{{item.user_Id}}</span>
                  <span class="time">
                    {{item.article_Time}}
                  </span>
                </span>
              </div>
              <div class="na_middle">
                <img class="nam_left"
                     src="@/common/images/pic.jpg"
                     alt="">
                <span class="nam_right">
                  <span class="title">
                    {{item.article_Name}}
                  </span>
                  <span class="article">
                    {{articles[0]}}
                  </span>
                  <span class="el-icon-thumb like">
                    666
                  </span>
                </span>
              </div>
            </div>

          </el-tab-pane>
          <el-tab-pane label="热门资讯"
                       name="hotMsg">角色管理</el-tab-pane>
          <el-tab-pane label="收藏排行"
                       name="likeSort">定时任务补偿</el-tab-pane>
        </el-tabs>
      </el-col>
    </el-row>
    <el-pagination background
                   layout="prev, pager, next"
                   :total="1000">
    </el-pagination>
  </div>
</template>
<script>
import { formatDate } from '@/common/core/tools.js'
export default {
  data () {
    return {
      value: 0,
      articles: [],
      activeName: 'newArticles'
    }
  },
  mounted () {
    this.getArticles()
  },
  methods: {
    getArticles () {
      var houURL = 'https://localhost:44324'
      var url = houURL + '/api/articles/getallarticles'
      console.log(url)
      this.$axios.get(url)
        .then(res => {
          console.log(res)
          res.data.forEach(u => {
            u.article_Time = formatDate(new Date(u.article_Time), 'yyyy-MM-dd hh:mm')
          })
          this.articles = res.data
        })
    },
    handleClick () {

    }
  }
}
</script>

<style lang="less" scope>
.articles {
  .el-row {
    .el-col {
      .el-tabs {
        .el-tab-pane {
          margin-bottom: 0.1rem;
          > div {
            background-color: white;
            border-radius: 10px;
            padding: 0.2rem;
            margin-bottom: 0.1rem;
            .na_top {
              display: flex;
              justify-items: center;
              margin-bottom: 0.1rem;
              .nat_left {
              }
              .nat_right {
                display: flex;
                flex-direction: column;
                color: #5a6169;
                font-size: 14px;
                margin-left: 0.1rem;
                padding: 0.01rem 0;
                .user {
                  text-align: left;
                  margin-bottom: 0.05rem;
                }
                .time {
                  color: #ccc;
                  font-size: 12px;
                }
              }
            }
            .na_middle {
              display: flex;
              justify-content: space-between;
              .nam_left {
                width: 20%;
                border-radius: 0.1rem;
              }
              .nam_right {
                margin-left: 0.2rem;
                position: relative;
                .title {
                  float: left;
                  font-size: 20px;
                  margin-bottom: 0.2rem;
                }
                .article {
                  display: inline-block;
                  text-align: left;
                  font-size: 13px;
                  color: #999;
                }
                .like {
                  position: absolute;
                  display: inline-block;
                  left: 0;
                  bottom: 0;
                  color: #c5c5c5;
                  font-size: 12px;
                }
              }
            }
          }
        }
      }
    }
  }
}
</style>
