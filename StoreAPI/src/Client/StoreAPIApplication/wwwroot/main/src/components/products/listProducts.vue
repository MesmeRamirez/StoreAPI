<template>
  <div class="custom-container">
    <h2 class="page-tittle">Product List</h2>
    <el-table :data="items.filter(data => !search || data.productName.toLowerCase().includes(search.toLowerCase()))" style="width: 100%">
      <el-table-column label="Product Name" prop="productName" sortable></el-table-column>
      <el-table-column label="Price" prop="price"></el-table-column>
      <el-table-column label="Likes" prop="likes"><span><i class="fa-heart"></i>{{items.likes}}</span></el-table-column>
      <el-table-column align="right">
        <template slot="header" slot-scope="scope">
          <el-input v-model="search" size="mini" placeholder="Type to search"/>
        </template>
        <template slot-scope="scope">
          <el-button size="mini" @click="$router.push(`/products/${scope.row.id}/edit`)">Buy</el-button>
        </template>
      </el-table-column>
    </el-table>
  </div>
</template>

<script>
  export default {
    name: "listProducts", 
    data() {
      return {
        items: [],
        search: '',
        loading: true
      };      
    },
    methods: {
      getAll() {
        let self = this;
        self.$store.state.services.productService.getAll()
          .then(r => {
            self.loading = false;
            self.items = r.data
          })
          .catch(r => {
            console.log(r);
            self.loading = false;
          });
      }
    },
    created() {
      let self = this
      self.getAll()
    }
  }
</script>
<style>
.fa-heart:before {
    content: "\f004";
    font-family: FontAwesome;
    font-style: normal;
    font-weight: normal;
    text-decoration: inherit;
/*--adjust as necessary--*/
    color: #8B0000;
    font-size: 12px;
    padding-right: 0.5em;
    position: absolute;
    top: 10px;
    left: 0;
}
</style>