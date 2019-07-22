<template>
<el-container>
<el-form ref="form" :model="form" :rules="rules" label-width="120px">
  <h2>Create a new Product</h2>

  <el-form-item label="Product Name" prop="ProductName">
    <el-input v-model="form.ProductName"></el-input>
  </el-form-item>

  <el-form-item label="Quantity" prop="Quantity">
    <el-input v-model="form.Quantity"></el-input>
  </el-form-item>

  <el-form-item label="Price ($)" prop="Price">
    <el-input v-model="form.Price"></el-input>
  </el-form-item>

  <el-form-item>
    <el-button type="primary" @click="onSubmit">Create</el-button>
    <el-button @click="$router.push('/')">Cancel</el-button>
  </el-form-item>

</el-form>
</el-container>
</template>

<script>
export default {
  name: 'createProducts',
  data: () => {
    return {
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
          Price: null
      }
    };    
  },
  methods: {
    onSubmit(){
      let self = this;
      console.log(self.form);
    },
    get(){
      let self = this;
      self.$store.state.services.productService.get()
    }
  }
};
</script>