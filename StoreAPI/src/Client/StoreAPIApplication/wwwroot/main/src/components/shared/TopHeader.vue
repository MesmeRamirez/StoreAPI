<template>
  <el-row>
    <el-col :span="12">
      <h1 @click="goTo('/')" style="">Boutique Party Store</h1>
    </el-col>
    <el-col :span="12" class="text-right user-options" style="text-align: right;">
      <a class="item" href="#/user-information">
        <i class="fa fa-user"></i>&nbsp;{{ user.Email }}
      </a>
      <a class="item" href="http://localhost:50847/Account/Logout">
        <i class="fa fa-sign-out"></i>
      </a>
    </el-col>
  </el-row>
</template>

<style>
#header {
  height: 60px;
  line-height: 60px;
  background: #fff;
  border-bottom: 1px solid #ccc;
  box-shadow: 0px 0px 15px 0px #eee;
}

#header h1 {
  margin: 0;
  color: #2d2f33;
}

#header .user-options a{
  color: #222;
  text-decoration: none;
}

#header .user-options .item {
  font-size: 1em;
  padding:5px 15px;
  border-radius:10px;
  margin-right: 5px;
}

#header .user-options .item:hover {
  background:#fff;
}

#header .el-header .user-options .item:last-child {
  margin-right: 0;
}
</style>

<script>
export default {
  name: "TopHeader",
  data: () => ({
    user: window.user
  }),
  methods: {
    goTo(path) {
      debugger
      if(path === undefined) return;
      this.$router.push(path);
    }
  }
};
</script>