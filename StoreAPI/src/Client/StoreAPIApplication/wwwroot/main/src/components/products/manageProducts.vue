<template>
  <div class="custom-container">
    <h2 class="page-tittle">Product List</h2>
    <el-table :data="items.filter(data => !search || data.productName.toLowerCase().includes(search.toLowerCase()))" style="width: 100%">
      <el-table-column label="Product Name" prop="productName" sortable></el-table-column>
      <el-table-column label="Quantity" prop="quantity"></el-table-column>
      <el-table-column label="Price" prop="price"></el-table-column>
      <el-table-column align="right">
        <template slot="header" slot-scope="scope">
          <el-input v-model="search" size="mini" placeholder="Type to search"/>
        </template>
        <template slot-scope="scope">
          <el-button size="mini" @click="$router.push(`/products/${scope.row.id}/edit`)">Edit</el-button>
          <el-button size="mini" type="danger" @click="handleDelete(scope.row.id)">Delete</el-button>
        </template>
      </el-table-column>
    </el-table>
  </div>
</template>

<script>
  export default {
    name: "manageProducts", 
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
      },
      handleDelete(id) {  
        let self = this;
        self.$confirm("Esta seguro de realizar esta acción?", "Confirmación", {
            confirmButtonText: "Si",
            cancelButtonText: "Cancelar",
            type: "warning"
          })
          .then(() => {
            _remove();
          })
          .catch(() => {});

        function _remove() {
          self.$store.state.services.productService.remove(id)
            .then(r => {
              self.loading = false;
              self.getAll();
            })
            .catch(r => {
              self.$message({
                message: "Ocurrió un error inesperado",
                type: "error"
              });
            });
        }
      }
    },
    created() {
      let self = this
      self.getAll()
    }
  }
</script>