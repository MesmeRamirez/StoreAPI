<template>
<el-container>
<el-main>
      <el-table :data="tableData">
        <el-table-column prop="ProductName" label="Product Name" width="140">
        </el-table-column>
        <el-table-column prop="Quantity" label="Quantity" width="120">
        </el-table-column>
        <el-table-column prop="Price" label="Price">
        </el-table-column>
      </el-table>
    </el-main>
</el-container>
</template>

<style>
  .el-header {
    background-color: #B3C0D1;
    color: #333;
    line-height: 60px;
  }
  
  .el-aside {
    color: #333;
  }
</style>

<script>
export default {
  name: 'Product',
  data: () => {
    return {
      form: {
          ProductName: null,
          Quantity: null,
          Price: null
      }
    };    
  },
  methods: {
    getAll(){
      let self = this;
      self.$store.state.services.productService.getAll(10)
      .then(r => {
        self.data = r.data;
      }).catch(r => {
        console.log(r);
      })
    }
  },
  created(){
    let self = this;
    selt.getAll();
  }
}
</script>