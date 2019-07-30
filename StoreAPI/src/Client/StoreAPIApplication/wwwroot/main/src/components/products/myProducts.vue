<template>
  <div class="custom-container">
    <h2 class="page-tittle">Previous purchases</h2>
    <el-table :data="items.filter(data => !search || data.productName.toLowerCase().includes(search.toLowerCase()))" style="width: 100%">
      <el-table-column label="Product Name" prop="productName" id="productName" sortable></el-table-column>
      <el-table-column label="Price" prop="price" id="price"></el-table-column>
      <el-table-column label="Quantity" prop="quantity" id="quantity"></el-table-column>
      <el-table-column align="right">
        <template slot="header" slot-scope="scope">
          <el-input v-model="search" size="mini" placeholder="Type to search"/>
        </template>
      </el-table-column>
    </el-table>
  </div>
</template>

<script>
  export default {
    name: "myProducts", 
    data() {
      return {
        items: {},
        search: '',
        loading: true
      };      
    },
    methods: {
      getAll() {
        let self = this;
        self.$store.state.services.buyService.getAll(window.user.UserId)
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
    color: #000;
    font-size: 15px;
    padding-right: 0.5em;
    left: 0;
}
.fa-heart-active:before {
    content: "\f004";
    font-family: FontAwesome;
    font-style: normal;
    font-weight: normal;
    text-decoration: inherit;
/*--adjust as necessary--*/
    color: #8B0000;
    font-size: 15px;
    padding-right: 0.5em;
    position: absolute;
    top: 10px;
    left: 0;
}
</style>