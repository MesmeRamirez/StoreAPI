webpackJsonp([1],{E6GN:function(e,t){},H0vN:function(e,t){},NHnr:function(e,t,r){"use strict";function n(e){r("OTTb")}function a(e){r("eWLW")}function i(e){r("E6GN")}Object.defineProperty(t,"__esModule",{value:!0});var o=r("7+uW"),l=r("zL8q"),s=r.n(l),c=r("JR9b"),u=r.n(c),d=(r("tvR6"),{name:"TopHeader",data:function(){return{user:window.user}},methods:{goTo:function(e){void 0!==e&&this.$router.push(e)}}}),m=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("el-row",[r("el-col",{attrs:{span:10}},[r("h1",{on:{click:function(t){return e.goTo("/")}}},[e._v("Boutique Party Store")])]),e._v(" "),r("el-col",{staticClass:"text-center",attrs:{span:4}},[r("el-input",{attrs:{placeholder:"Buscar ..","suffix-icon":"fa fa-search"}})],1),e._v(" "),r("el-col",{staticClass:"text-right user-options",staticStyle:{"text-align":"right"},attrs:{span:10}},[r("a",{staticClass:"item",attrs:{href:"#/user-information"}},[r("i",{staticClass:"fa fa-user"}),e._v(" "+e._s(e.user.Email)+"\n    ")]),e._v(" "),r("a",{staticClass:"item",attrs:{href:"#"}},[r("i",{staticClass:"fa fa-sign-out"})])])],1)},f=[],p={render:m,staticRenderFns:f},h=p,v=r("VU/8"),g=n,_=v(d,h,!1,g,null,null),b=_.exports,y={name:"NavegationMenu",data:function(){return{items:[{icon:"list",text:"Products",path:"/"},{icon:"star",text:"My Cart",children:[{icon:"list",text:"My Shoppings",path:"/example"}]},{icon:"wrench",text:"Configuration",children:[{icon:"plus",text:"Create Products",path:"/add-products"},{icon:"wrench",text:"Manage Products",path:"/manage-products"}]}]}},methods:{redirect:function(e){void 0!==e&&this.$router.push(e)}}},x=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("el-menu",{attrs:{"default-active":"0"}},[e._l(e.items,function(t,n){return[void 0!==t.children?r("el-submenu",{attrs:{index:n.toString()}},[r("template",{slot:"title"},[r("i",{class:"fa fa-"+t.icon}),e._v(" "),r("span",[e._v(e._s(t.text))])]),e._v(" "),r("el-menu-item-group",{attrs:{title:"Options"}},e._l(t.children,function(t,a){return r("el-menu-item",{attrs:{index:n.toString()+a},on:{click:function(r){return e.redirect(t.path)}}},[r("i",{class:"fa fa-"+t.icon}),e._v(" "),r("span",[e._v(e._s(t.text))])])}),1)],2):e._e(),e._v(" "),void 0===t.children?r("el-menu-item",{attrs:{index:"2"},on:{click:function(r){return e.redirect(t.path)}}},[r("i",{class:"fa fa-"+t.icon}),e._v(" "),r("span",[e._v(e._s(t.text))])]):e._e()]})],2)},P=[],w={render:x,staticRenderFns:P},$=w,N=r("VU/8"),k=N(y,$,!1,null,null,null),S=k.exports,U={components:{topheader:b,navegationmenu:S},props:{source:String}},C=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("el-container",[r("el-header",{attrs:{id:"header"}},[r("topheader")],1),e._v(" "),r("el-container",[r("el-aside",{staticStyle:{width:"240px"}},[r("navegationmenu")],1),e._v(" "),r("el-container",[r("el-main",[r("el-row",[r("el-col",{attrs:{span:24}},[r("router-view")],1)],1)],1),e._v(" "),r("el-footer")],1)],1)],1)},E=[],Q={render:C,staticRenderFns:E},T=Q,A=r("VU/8"),R=A(U,T,!1,null,null,null),q=R.exports,I=r("/ocq"),L={name:"Information",created:function(){this.get()},data:function(){return{form:{userName:null,email:null}}},methods:{get:function(){var e=this;e.$store.state.services.userService.get(window.user.UserId).then(function(t){e.form=t.data}).catch(function(e){console.log(e)})}}},F=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("el-container",[r("el-form",{ref:"form",attrs:{model:e.form,"label-width":"120px"}},[r("h2",{staticClass:"page-title"},[e._v("Personal Information")]),e._v(" "),r("el-form-item",{attrs:{label:"User Name"}},[r("el-input",{attrs:{readonly:!0},model:{value:e.form.userName,callback:function(t){e.$set(e.form,"userName",t)},expression:"form.userName"}})],1),e._v(" "),r("el-form-item",{attrs:{label:"Email"}},[r("el-input",{attrs:{readonly:!0},model:{value:e.form.email,callback:function(t){e.$set(e.form,"email",t)},expression:"form.email"}})],1)],1)],1)},V=[],B={render:F,staticRenderFns:V},O=B,z=r("VU/8"),M=z(L,O,!1,null,null,null),W=M.exports,D={name:"createProducts",data:function(){return{loading:!1,rules:{ProductName:[{required:!0,message:"This field is required",trigger:"blur"},{min:3,max:25,message:"Length must be 3 to 25 characters",trigger:"blur"}],Quantity:[{required:!0,message:"This field is required",trigger:"blur"}],Price:[{required:!0,message:"This field is required",trigger:"blur"}]},form:{ProductName:null,Quantity:null,Price:null,UrlImage:null,UserId:window.user.UserId}}},created:function(){},methods:{onSubmit:function(){var e=this,t=this;t.$refs.form.validate(function(r){r&&t.$store.state.services.productService.create(t.form).then(function(r){t.loading=!1,e.$alert("The product has been created successfully","New product created",{confirmButtonText:"OK"}),document.getElementById("ProductName").value="",document.getElementById("Quantity").value="",document.getElementById("Price").value=""}).catch(function(e){t.$message({message:"Ocurrió un error inesperado",type:"error"})})})}}},H=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("div",{staticClass:"custom-container"},[r("h2",{staticClass:"page-tittle"},[e._v("Create a new Product")]),e._v(" "),r("el-form",{directives:[{name:"loading",rawName:"v-loading",value:e.loading,expression:"loading"}],ref:"form",attrs:{model:e.form,rules:e.rules,"label-width":"120px"}},[r("el-form-item",{attrs:{label:"Product Name",prop:"ProductName"}},[r("el-input",{attrs:{id:"ProductName"},model:{value:e.form.ProductName,callback:function(t){e.$set(e.form,"ProductName",t)},expression:"form.ProductName"}})],1),e._v(" "),r("el-form-item",{attrs:{label:"Quantity",prop:"Quantity"}},[r("el-input",{attrs:{id:"Quantity"},model:{value:e.form.Quantity,callback:function(t){e.$set(e.form,"Quantity",t)},expression:"form.Quantity"}})],1),e._v(" "),r("el-form-item",{attrs:{label:"Price ($)",prop:"Price"}},[r("el-input",{attrs:{id:"Price"},model:{value:e.form.Price,callback:function(t){e.$set(e.form,"Price",t)},expression:"form.Price"}})],1),e._v(" "),r("el-form-item",[r("el-button",{attrs:{type:"primary"},on:{click:e.onSubmit}},[e._v("Create")]),e._v(" "),r("el-button",{on:{click:function(t){return e.$router.push("/")}}},[e._v("Cancel")])],1)],1)],1)},j=[],G={render:H,staticRenderFns:j},J=G,K=r("VU/8"),Z=K(D,J,!1,null,null,null),X=Z.exports,Y={name:"editProducts",data:function(){return{loading:!1,rules:{ProductName:[{required:!0,message:"This field is required",trigger:"blur"},{min:3,max:25,message:"Length must be 3 to 25 characters",trigger:"blur"}],Quantity:[{required:!0,message:"This field is required",trigger:"blur"}],Price:[{required:!0,message:"This field is required",trigger:"blur"}]},form:{ProductName:null,Quantity:null,Price:null,UrlImage:null,UserId:window.user.UserId}}},created:function(){var e=this;e.get(e.$route.params.id)},methods:{get:function(e){if(void 0!=e){var t=this;t.loading=!0,t.$store.state.services.productService.get(e).then(function(e){t.loading=!1,t.form.ProductName=e.data.productName,t.form.Quantity=e.data.quantity,t.form.Price=e.data.price}).catch(function(e){t.$message({message:"Ocurrió un error inesperado",type:"error"})})}},onSubmit:function(){var e=this,t=this;t.$refs.form.validate(function(r){r&&(t.loading=!0,console.log(t.$route.params.id),t.$store.state.services.productService.partial(t.$route.params.id,t.form).then(function(r){t.loading=!1,e.$alert("The product has been updated successfully","Product updated",{confirmButtonText:"OK"}),t.get(t.$route.params.id)}).catch(function(e){t.$message({message:"Ocurrió un error inesperado",type:"error"})}))})}}},ee=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("div",{staticClass:"custom-container"},[r("h2",{staticClass:"page-tittle"},[e._v("Edit Product")]),e._v(" "),r("el-form",{directives:[{name:"loading",rawName:"v-loading",value:e.loading,expression:"loading"}],ref:"form",attrs:{model:e.form,rules:e.rules,"label-width":"120px"}},[r("el-form-item",{attrs:{label:"Product Name",prop:"ProductName"}},[r("el-input",{attrs:{id:"ProductName"},model:{value:e.form.ProductName,callback:function(t){e.$set(e.form,"ProductName",t)},expression:"form.ProductName"}})],1),e._v(" "),r("el-form-item",{attrs:{label:"Quantity",prop:"Quantity"}},[r("el-input",{attrs:{id:"Quantity"},model:{value:e.form.Quantity,callback:function(t){e.$set(e.form,"Quantity",t)},expression:"form.Quantity"}})],1),e._v(" "),r("el-form-item",{attrs:{label:"Price ($)",prop:"Price"}},[r("el-input",{attrs:{id:"Price"},model:{value:e.form.Price,callback:function(t){e.$set(e.form,"Price",t)},expression:"form.Price"}})],1),e._v(" "),r("el-form-item",[r("el-button",{attrs:{type:"primary"},on:{click:e.onSubmit}},[e._v("Save")]),e._v(" "),r("el-button",{on:{click:function(t){return e.$router.push("/manage-products")}}},[e._v("Cancel")])],1)],1)],1)},te=[],re={render:ee,staticRenderFns:te},ne=re,ae=r("VU/8"),ie=ae(Y,ne,!1,null,null,null),oe=ie.exports,le={name:"manageProducts",data:function(){return{items:[],search:"",loading:!0}},methods:{getAll:function(){var e=this;e.$store.state.services.productService.getAll().then(function(t){e.loading=!1,e.items=t.data}).catch(function(t){console.log(t),e.loading=!1})},handleDelete:function(e){function t(){r.$store.state.services.productService.remove(e).then(function(e){r.loading=!1,r.getAll()}).catch(function(e){r.$message({message:"Ocurrió un error inesperado",type:"error"})})}var r=this;r.$confirm("Esta seguro de realizar esta acción?","Confirmación",{confirmButtonText:"Si",cancelButtonText:"Cancelar",type:"warning"}).then(function(){t()}).catch(function(){})}},created:function(){this.getAll()}},se=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("div",{staticClass:"custom-container"},[r("h2",{staticClass:"page-tittle"},[e._v("Product List")]),e._v(" "),r("el-table",{staticStyle:{width:"100%"},attrs:{data:e.items.filter(function(t){return!e.search||t.productName.toLowerCase().includes(e.search.toLowerCase())})}},[r("el-table-column",{attrs:{label:"Product Name",prop:"productName",sortable:""}}),e._v(" "),r("el-table-column",{attrs:{label:"Quantity",prop:"quantity"}}),e._v(" "),r("el-table-column",{attrs:{label:"Price",prop:"price"}}),e._v(" "),r("el-table-column",{attrs:{align:"right"},scopedSlots:e._u([{key:"header",fn:function(t){return[r("el-input",{attrs:{size:"mini",placeholder:"Type to search"},model:{value:e.search,callback:function(t){e.search=t},expression:"search"}})]}},{key:"default",fn:function(t){return[r("el-button",{attrs:{size:"mini"},on:{click:function(r){return e.$router.push("/products/"+t.row.id+"/edit")}}},[e._v("Edit")]),e._v(" "),r("el-button",{attrs:{size:"mini",type:"danger"},on:{click:function(r){return e.handleDelete(t.row.id)}}},[e._v("Delete")])]}}])})],1)],1)},ce=[],ue={render:se,staticRenderFns:ce},de=ue,me=r("VU/8"),fe=me(le,de,!1,null,null,null),pe=fe.exports,he={name:"Product",data:function(){return{form:{ProductName:null,Quantity:null,Price:null}}},methods:{getAll:function(){var e=this;e.$store.state.services.productService.getAll(10).then(function(t){e.data=t.data}).catch(function(e){console.log(e)})}},created:function(){selt.getAll()}},ve=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("el-container",[r("el-main",[r("el-table",{attrs:{data:e.tableData}},[r("el-table-column",{attrs:{prop:"ProductName",label:"Product Name",width:"140"}}),e._v(" "),r("el-table-column",{attrs:{prop:"Quantity",label:"Quantity",width:"120"}}),e._v(" "),r("el-table-column",{attrs:{prop:"Price",label:"Price"}})],1)],1)],1)},ge=[],_e={render:ve,staticRenderFns:ge},be=_e,ye=r("VU/8"),xe=a,Pe=ye(he,be,!1,xe,null,null),we=Pe.exports,$e={name:"listProducts",data:function(){return{items:[],search:"",loading:!0}},methods:{getAll:function(){var e=this;e.$store.state.services.productService.getAll().then(function(t){e.loading=!1,e.items=t.data}).catch(function(t){console.log(t),e.loading=!1})}},created:function(){this.getAll()}},Ne=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("div",{staticClass:"custom-container"},[r("h2",{staticClass:"page-tittle"},[e._v("Product List")]),e._v(" "),r("el-table",{staticStyle:{width:"100%"},attrs:{data:e.items.filter(function(t){return!e.search||t.productName.toLowerCase().includes(e.search.toLowerCase())})}},[r("el-table-column",{attrs:{label:"Product Name",prop:"productName",sortable:""}}),e._v(" "),r("el-table-column",{attrs:{label:"Price",prop:"price"}}),e._v(" "),r("el-table-column",{attrs:{label:"Likes",prop:"likes"}},[r("span",[r("i",{staticClass:"fa-heart"}),e._v(e._s(e.items.likes))])]),e._v(" "),r("el-table-column",{attrs:{align:"right"},scopedSlots:e._u([{key:"header",fn:function(t){return[r("el-input",{attrs:{size:"mini",placeholder:"Type to search"},model:{value:e.search,callback:function(t){e.search=t},expression:"search"}})]}},{key:"default",fn:function(t){return[r("el-button",{attrs:{size:"mini"},on:{click:function(r){return e.$router.push("/products/"+t.row.id+"/edit")}}},[e._v("Buy")])]}}])})],1)],1)},ke=[],Se={render:Ne,staticRenderFns:ke},Ue=Se,Ce=r("VU/8"),Ee=i,Qe=Ce($e,Ue,!1,Ee,null,null),Te=Qe.exports,Ae={name:"ExampleIndex",data:function(){return{loading:!1,items:[]}},created:function(){this.getAll()},methods:{getAll:function(){var e=this;e.loading=!0,e.$store.state.services.exampleService.getAll().then(function(t){e.loading=!1,e.items=t.data}).catch(function(e){})}}},Re=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("div",[r("h2",[e._v("Products")]),e._v(" "),r("div",{directives:[{name:"loading",rawName:"v-loading",value:e.loading,expression:"loading"}]},[r("el-table",{staticStyle:{width:"100%"},attrs:{data:e.items,"default-sort":{prop:"title",order:"ascending"}}},[r("el-table-column",{attrs:{prop:"Id",label:"Product Id",sortable:"",width:"50"}}),e._v(" "),r("el-table-column",{attrs:{prop:"ProductName",label:"Product Name",sortable:""},scopedSlots:e._u([{key:"default",fn:function(t){return[r("a",{attrs:{href:"#/example/"+t.row.id}},[e._v(e._s(t.row.title))])]}}])}),e._v(" "),r("el-table-column",{attrs:{prop:"Quantity",label:"Quantity in stock"}}),e._v(" "),r("el-table-column",{attrs:{prop:"Price",label:"Price"}})],1)],1)])},qe=[],Ie={render:Re,staticRenderFns:qe},Le=Ie,Fe=r("VU/8"),Ve=Fe(Ae,Le,!1,null,null,null),Be=Ve.exports,Oe={name:"ExampleView",data:function(){return{loading:!1,model:{}}},created:function(){var e=this;e.get(e.$route.params.id)},methods:{get:function(e){var t=this;t.loading=!0,t.$store.state.services.exampleService.get(e).then(function(e){t.loading=!1,t.model=e.data}).catch(function(e){})}}},ze=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("div",{directives:[{name:"loading",rawName:"v-loading",value:e.loading,expression:"loading"}]},[r("h2",[e._v(e._s(e.model.title))]),e._v("\n"+e._s(e.model.body)+"\n")])},Me=[],We={render:ze,staticRenderFns:Me},De=We,He=r("VU/8"),je=He(Oe,De,!1,null,null,null),Ge=je.exports;o.default.use(I.a);var Je=[{path:"/user-information",name:"UserInfo",component:W},{path:"/add-products",name:"AddProducts",component:X},{path:"/products/:id/edit",name:"EditProducts",component:oe},{path:"/manage-products",name:"ManageProducts",component:pe},{path:"/products",name:"ListProducts",component:we},{path:"/",name:"ListBuyProducts",component:Te},{path:"/example",name:"ExampleIndex",component:Be},{path:"/example/:id",name:"ExampleView",component:Ge}],Ke=new I.a({routes:Je}),Ze=r("uUlv"),Xe=r("mtWM"),Ye=r.n(Xe),et=r("Zrlr"),tt=r.n(et),rt=r("wxAW"),nt=r.n(rt),at=function(){function e(t,r){tt()(this,e),this.axios=t,this.baseUrl=r}return nt()(e,[{key:"get",value:function(e){var t=this;return t.axios.get(t.baseUrl+"products/"+e)}},{key:"getAll",value:function(){var e=this;return e.axios.get(e.baseUrl+"products")}},{key:"partial",value:function(e,t){var r=this;return r.axios.patch(r.baseUrl+"products/"+e,t)}},{key:"image",value:function(e,t){var r=this;return r.axios.put(r.baseUrl+"/"+e+"/image",t)}},{key:"create",value:function(e){var t=this;return t.axios.post(t.baseUrl+"products",e)}},{key:"remove",value:function(e){var t=this;return t.axios.delete(t.baseUrl+"products/"+e)}}]),e}(),it=at,ot=function(){function e(t,r){tt()(this,e),this.axios=t,this.baseUrl=r}return nt()(e,[{key:"get",value:function(e){var t=this;return t.axios.get(t.baseUrl+"users/"+e)}},{key:"refreshClaims",value:function(){window.location.href="/auth/refresh"}}]),e}(),lt=ot,st=r("//Fk"),ct=r.n(st),ut=function(){function e(){tt()(this,e)}return nt()(e,[{key:"get",value:function(e){var t=new FileReader;return t.readAsDataURL(e),new ct.a(function(r,n){try{t.onload=function(){r({content:t.result.split(",")[1],name:name||e.name,lenght:e.size,contentType:e.type})}}catch(e){n(e)}})}},{key:"refreshClaims",value:function(){window.location.href="/auth/refresh"}}]),e}(),dt=ut;Ye.a.defaults.headers.common.Accept="application/json",Ye.a.defaults.headers.common.Authorization="bearer "+user.Token;var mt={productService:new it(Ye.a,window.Api.URL),userService:new lt(Ye.a,window.Api.URL),fileService:new dt};o.default.use(Ze.a);var ft={services:mt},pt=new Ze.a.Store({state:ft});r("H0vN");o.default.config.productionTip=!1,o.default.use(s.a,{locale:u.a}),new o.default({el:"#app",router:Ke,store:pt,template:"<App/>",components:{App:q}})},OTTb:function(e,t){},eWLW:function(e,t){},tvR6:function(e,t){}},["NHnr"]);
//# sourceMappingURL=app.5e8af753a294a4be3e9e.js.map