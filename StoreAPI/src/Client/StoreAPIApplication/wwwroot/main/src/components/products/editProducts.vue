<template>
<div class="custom-container" v-loading="loading">
  <h2 class="page-tittle">Edit Product</h2>
  <el-tabs v-model="selectedTab">
    <el-tab-pane label="Product Information" name="first">
      <el-form v-loading="loading" ref="form" :model="form" :rules="rules" label-width="120px">
      <el-form-item label="Product Name" prop="ProductName">
        <el-input v-model="form.ProductName" id="ProductName"></el-input>
      </el-form-item>
      <el-form-item label="Quantity" prop="Quantity">
        <el-input v-model="form.Quantity" id="Quantity"></el-input>
      </el-form-item>
      <el-form-item label="Price ($)" prop="Price">
        <el-input v-model="form.Price" id="Price"></el-input>
      </el-form-item>
      <el-form-item>
        <el-button type="primary" @click="onSubmit">Save</el-button>
        <el-button @click="$router.push('/manage-products')">Cancel</el-button>
      </el-form-item>
    </el-form>
    </el-tab-pane>
    <el-tab-pane label="Image" name="second">
      <el-form label-width="120px">
        <el-form-item label="Image" prop="UrlImage">
          <input id="UrlImage" type="file" accept="image/*"></input>
        </el-form-item>
        <el-form-item>
          <el-button type="primary" @click="upload">Upload</el-button>
        </el-form-item>
      </el-form>
    </el-tab-pane>
  </el-tabs>
</div>
</template>

<script>
export default {
  name: 'editProducts',
  data: () => {
    return {
      loading: false,
      selectedTab: "first",
      rules: {
        ProductName: [
          {
            required: true,
            message: "This field is required",
            trigger: "blur"
          },
          {
            min: 3,
            max: 25,
            message: "Length must be 3 to 25 characters",
            trigger: "blur"
          }
        ],
        Quantity: [
          {
            required: true,
            message: "This field is required",
            trigger: "blur"
          }
        ],
        Price: [
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
          self.loading = true;
          console.log(self.$route.params.id);
          self.$store.state.services.productService
            .partial(self.$route.params.id, self.form)
            .then(r => {
              self.loading = false;
              this.$alert('The product has been updated successfully', 'Product updated', {
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
      });
    },
    upload() {
      let self = this,
          input = document.getElementById("UrlImage"),
          files = input.files;

      if (files != null || files.length > 0) {
        self.$store.state.services.fileService
          .get(files[0])
          .then(file => {
            self.loading = true;

            self.$store.state.services.productService
              .image(self.$route.params.id, file)
              .then(r2 => {
                self.loading = false;
                this.$alert('The image has been updated successfully', 'Product image updated', {
                  confirmButtonText: 'OK'
                }); 
                self.get(self.$route.params.id);
              })
              .catch(r2 => {
                self.loading = false;
                self.$message({
                  message: "Ocurrió un error inesperado",
                  type: "error"
                });
              });
          })
          .catch(r1 => {
            console.log(r1);
          });
      }
    }
  }
};
</script>