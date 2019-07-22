<template>
<el-container>
<el-form ref="form" :model="form" label-width="120px">
  <h2 class="page-title">Personal Information</h2>

  <el-form-item label="User Name">
    <el-input :readonly = "true" v-model="form.userName"></el-input>
  </el-form-item>
  
  <el-form-item label="Email">
    <el-input :readonly = "true" v-model="form.email"></el-input>
  </el-form-item>
  
</el-form>
</el-container>
</template>

<script>
export default {
  name: 'Information',
  created(){
    let self = this;
    self.get()
  },
  data: () => {
    return {
      form: {
          userName: null,
          email: null
      }
    };    
  },
  methods: {
    get(){
      let self = this;
      self.$store.state.services.userService.get(window.user.UserId)
      .then(r => {
        self.form = r.data;
      }).catch(r => {
        console.log(r)
      })
    }
  }
}
</script>