<template>
<div class="custom-container" v-loading="loading">
  <h2 class="page-tittle">Buy Product</h2>
  <el-form v-loading="loading" ref="form" :model="form" :rules="rules" label-width="120px">
    <el-form-item label="Product Name" prop="ProductName">
      <el-input v-model="form.ProductName" id="ProductName" :readonly = "true"></el-input>
    </el-form-item>
    <el-form-item label="Price ($)" prop="Price">
      <el-input v-model="form.Price" id="Price" :readonly = "true"></el-input>
    </el-form-item>
    <el-form-item label="Quantity" prop="Quantity">
      <el-input v-model="form.QuantityBuy" id="QuantityBuy"></el-input>
    </el-form-item>
    <el-divider></el-divider>
    <el-form-item>
      <el-button type="primary" @click="onSubmit">Buy</el-button>
      <el-button @click="$router.push('/')">Go back</el-button>
    </el-form-item>
  </el-form>
</div>
</template>

<script>
export default {
  name: 'editProducts',
  data: () => {
    return {
      loading: false,
      rules: {
        Quantity: [
          {
            required: true,
            message: "This field is required",
            trigger: "blur"
          }
        ]
      },
      form: {
          ProductName: null,
          Quantity: null,
          Price: null,
          UrlImage: null,
          UserId: window.user.UserId
      }
    };    
  },
  created() {
    let self = this;
    self.get(self.$route.params.id);
  },
  methods: {
    get(id){
      if(id == undefined) return;

      let self = this;
      self.loading = true;
      self.$store.state.services.productService
        .get(id)
        .then(r => {
          self.loading = false;
          self.form.ProductName = r.data.productName;
          self.form.Quantity = r.data.quantity;
          self.form.Price = r.data.price;
          self.form.UrlImage = r.data.urlImage;
        })
        .catch(r => {
          self.$message({
            message: "Ocurrió un error inesperado",
            type: "error"
          });
        });
    },
    onSubmit(){
      let self = this;
      self.$refs["form"].validate(valid => {
        if (valid) {
          if (self.form.QuantityBuy > self.form.Quantity) {
            self.$message({
                message: "We dont have enough products.",
                type: "error"
              });
          } else {
            self.loading = true;
            console.log(self.$route.params.id);
            self.$store.state.services.buyService
              .create({
                  UserId: window.user.UserId, 
                  ProductId: self.$route.params.id,
                  Quantity: self.form.QuantityBuy})
              .then(r => {
                self.loading = false;
                this.$alert('You have purchased the product successfully', 'Purchase', {
                  confirmButtonText: 'OK'
                }); 
                self.get(self.$route.params.id);
              })
              .catch(r => {
                self.$message({
                  message: "Ocurrió un error inesperado",
                  type: "error"
                });
              });
          }          
        }
      });
    },
    updateTotal(id){
      console.log(id);
    }
  }
};
</script>