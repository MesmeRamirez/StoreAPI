webpackJsonp([1],{H0vN:function(e,t){},NHnr:function(e,t,r){"use strict";function a(e){r("OTTb")}function n(e){r("eWLW")}Object.defineProperty(t,"__esModule",{value:!0});var i=r("7+uW"),o=r("zL8q"),l=r.n(o),s=r("JR9b"),u=r.n(s),c=(r("tvR6"),{name:"TopHeader",data:function(){return{user:window.user}},methods:{goTo:function(e){void 0!==e&&this.$router.push(e)}}}),d=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("el-row",[r("el-col",{attrs:{span:10}},[r("h1",{on:{click:function(t){return e.goTo("/")}}},[e._v("Boutique Party Store")])]),e._v(" "),r("el-col",{staticClass:"text-center",attrs:{span:4}},[r("el-input",{attrs:{placeholder:"Buscar ..","suffix-icon":"fa fa-search"}})],1),e._v(" "),r("el-col",{staticClass:"text-right user-options",staticStyle:{"text-align":"right"},attrs:{span:10}},[r("a",{staticClass:"item",attrs:{href:"#/user-information"}},[r("i",{staticClass:"fa fa-user"}),e._v(" "+e._s(e.user.Email)+"\n    ")]),e._v(" "),r("a",{staticClass:"item",attrs:{href:"#"}},[r("i",{staticClass:"fa fa-sign-out"})])])],1)},m=[],f={render:d,staticRenderFns:m},p=f,v=r("VU/8"),h=a,g=v(c,p,!1,h,null,null),_=g.exports,b={name:"NavegationMenu",data:function(){return{items:[{icon:"dashboard",text:"Dashboard",path:"/"},{icon:"star",text:"My Cart",children:[{icon:"list",text:"My Shoppings",path:"/example"}]},{icon:"wrench",text:"Configuration",children:[{icon:"plus",text:"Create Products",path:"/add-products"},{icon:"wrench",text:"Manage Products",path:"/manage-products"}]}]}},methods:{redirect:function(e){void 0!==e&&this.$router.push(e)}}},x=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("el-menu",{attrs:{"default-active":"0"}},[e._l(e.items,function(t,a){return[void 0!==t.children?r("el-submenu",{attrs:{index:a.toString()}},[r("template",{slot:"title"},[r("i",{class:"fa fa-"+t.icon}),e._v(" "),r("span",[e._v(e._s(t.text))])]),e._v(" "),r("el-menu-item-group",{attrs:{title:"Options"}},e._l(t.children,function(t,n){return r("el-menu-item",{attrs:{index:a.toString()+n},on:{click:function(r){return e.redirect(t.path)}}},[r("i",{class:"fa fa-"+t.icon}),e._v(" "),r("span",[e._v(e._s(t.text))])])}),1)],2):e._e(),e._v(" "),void 0===t.children?r("el-menu-item",{attrs:{index:"2"},on:{click:function(r){return e.redirect(t.path)}}},[r("i",{class:"fa fa-"+t.icon}),e._v(" "),r("span",[e._v(e._s(t.text))])]):e._e()]})],2)},y=[],P={render:x,staticRenderFns:y},w=P,$=r("VU/8"),N=$(b,w,!1,null,null,null),k=N.exports,U={components:{topheader:_,navegationmenu:k},props:{source:String}},S=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("el-container",[r("el-header",{attrs:{id:"header"}},[r("topheader")],1),e._v(" "),r("el-container",[r("el-aside",{staticStyle:{width:"240px"}},[r("navegationmenu")],1),e._v(" "),r("el-container",[r("el-main",[r("el-row",[r("el-col",{attrs:{span:24}},[r("router-view")],1)],1)],1),e._v(" "),r("el-footer")],1)],1)],1)},E=[],C={render:S,staticRenderFns:E},A=C,Q=r("VU/8"),T=Q(U,A,!1,null,null,null),R=T.exports,q=r("/ocq"),I={name:"Default"},V=function(){var e=this,t=e.$createElement;e._self._c;return e._m(0)},L=[function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("div",[r("h2",[e._v("Dashboard")]),e._v(" "),r("p",[e._v("La siguiente aplicación contiene:")]),e._v(" "),r("ul",[r("li",[r("b",[e._v("Vue")]),e._v(": nuestro framework para crear componentes")]),e._v(" "),r("li",[r("b",[e._v("Vuex")]),e._v(": para compartir recursos entre toda la aplicación.")]),e._v(" "),r("li",[r("b",[e._v("VueRouter")]),e._v(": para generar un router que nos permita navegar por las URL.")]),e._v(" "),r("li",[r("b",[e._v("Axios")]),e._v(": para trabajar las peticiones AJAX.")]),e._v(" "),r("li",[r("b",[e._v("Element Ui")]),e._v(": como bootstrap pero hecho y pensando para Vue.")])]),e._v(" "),r("p",[e._v("Proyecto base desarrollado por Anexsoft. Para visualizar un módulo desarrollado ingresa al menú de Ejemplo.")])])}],F={render:V,staticRenderFns:L},O=F,B=r("VU/8"),D=B(I,O,!1,null,null,null),z=D.exports,M={name:"Information",created:function(){this.get()},data:function(){return{form:{userName:null,email:null}}},methods:{get:function(){var e=this;e.$store.state.services.userService.get(window.user.UserId).then(function(t){e.form=t.data}).catch(function(e){console.log(e)})}}},W=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("el-container",[r("el-form",{ref:"form",attrs:{model:e.form,"label-width":"120px"}},[r("h2",{staticClass:"page-title"},[e._v("Personal Information")]),e._v(" "),r("el-form-item",{attrs:{label:"User Name"}},[r("el-input",{attrs:{readonly:!0},model:{value:e.form.userName,callback:function(t){e.$set(e.form,"userName",t)},expression:"form.userName"}})],1),e._v(" "),r("el-form-item",{attrs:{label:"Email"}},[r("el-input",{attrs:{readonly:!0},model:{value:e.form.email,callback:function(t){e.$set(e.form,"email",t)},expression:"form.email"}})],1)],1)],1)},H=[],j={render:W,staticRenderFns:H},J=j,K=r("VU/8"),X=K(M,J,!1,null,null,null),Z=X.exports,G={name:"createProducts",data:function(){return{loading:!1,rules:{ProductName:[{required:!0,message:"This field is required",trigger:"blur"},{min:3,max:25,message:"Length must be 3 to 25 characters",trigger:"blur"}],Quantity:[{required:!0,message:"This field is required",trigger:"blur"}],Price:[{required:!0,message:"This field is required",trigger:"blur"}]},form:{ProductName:null,Quantity:null,Price:null,UrlImage:null,UserId:window.user.UserId}}},created:function(){},methods:{onSubmit:function(){var e=this,t=this;t.$refs.form.validate(function(r){r&&t.$store.state.services.productService.create(t.form).then(function(r){t.loading=!1,e.$alert("The product has been created successfully","New product created",{confirmButtonText:"OK"}),document.getElementById("ProductName").value="",document.getElementById("Quantity").value="",document.getElementById("Price").value=""}).catch(function(e){t.$message({message:"Ocurrió un error inesperado",type:"error"})})})}}},Y=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("div",{staticClass:"custom-container"},[r("h2",{staticClass:"page-tittle"},[e._v("Create a new Product")]),e._v(" "),r("el-form",{directives:[{name:"loading",rawName:"v-loading",value:e.loading,expression:"loading"}],ref:"form",attrs:{model:e.form,rules:e.rules,"label-width":"120px"}},[r("el-form-item",{attrs:{label:"Product Name",prop:"ProductName"}},[r("el-input",{attrs:{id:"ProductName"},model:{value:e.form.ProductName,callback:function(t){e.$set(e.form,"ProductName",t)},expression:"form.ProductName"}})],1),e._v(" "),r("el-form-item",{attrs:{label:"Quantity",prop:"Quantity"}},[r("el-input",{attrs:{id:"Quantity"},model:{value:e.form.Quantity,callback:function(t){e.$set(e.form,"Quantity",t)},expression:"form.Quantity"}})],1),e._v(" "),r("el-form-item",{attrs:{label:"Price ($)",prop:"Price"}},[r("el-input",{attrs:{id:"Price"},model:{value:e.form.Price,callback:function(t){e.$set(e.form,"Price",t)},expression:"form.Price"}})],1),e._v(" "),r("el-form-item",[r("el-button",{attrs:{type:"primary"},on:{click:e.onSubmit}},[e._v("Create")]),e._v(" "),r("el-button",{on:{click:function(t){return e.$router.push("/")}}},[e._v("Cancel")])],1)],1)],1)},ee=[],te={render:Y,staticRenderFns:ee},re=te,ae=r("VU/8"),ne=ae(G,re,!1,null,null,null),ie=ne.exports,oe={name:"editProducts",data:function(){return{loading:!1,rules:{ProductName:[{required:!0,message:"This field is required",trigger:"blur"},{min:3,max:25,message:"Length must be 3 to 25 characters",trigger:"blur"}],Quantity:[{required:!0,message:"This field is required",trigger:"blur"}],Price:[{required:!0,message:"This field is required",trigger:"blur"}]},form:{ProductName:null,Quantity:null,Price:null,UrlImage:null,UserId:window.user.UserId}}},created:function(){var e=this;e.get(e.$route.params.id)},methods:{get:function(e){if(void 0!=e){var t=this;t.loading=!0,t.$store.state.services.productService.get(e).then(function(e){t.loading=!1,t.form.ProductName=e.data.productName,t.form.Quantity=e.data.quantity,t.form.Price=e.data.price}).catch(function(e){t.$message({message:"Ocurrió un error inesperado",type:"error"})})}},onSubmit:function(){var e=this,t=this;t.$refs.form.validate(function(r){r&&(t.loading=!0,console.log(t.$route.params.id),t.$store.state.services.productService.partial(t.$route.params.id,t.form).then(function(r){t.loading=!1,e.$alert("The product has been updated successfully","Product updated",{confirmButtonText:"OK"}),t.get(t.$route.params.id)}).catch(function(e){t.$message({message:"Ocurrió un error inesperado",type:"error"})}))})}}},le=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("div",{staticClass:"custom-container"},[r("h2",{staticClass:"page-tittle"},[e._v("Edit Product")]),e._v(" "),r("el-form",{directives:[{name:"loading",rawName:"v-loading",value:e.loading,expression:"loading"}],ref:"form",attrs:{model:e.form,rules:e.rules,"label-width":"120px"}},[r("el-form-item",{attrs:{label:"Product Name",prop:"ProductName"}},[r("el-input",{attrs:{id:"ProductName"},model:{value:e.form.ProductName,callback:function(t){e.$set(e.form,"ProductName",t)},expression:"form.ProductName"}})],1),e._v(" "),r("el-form-item",{attrs:{label:"Quantity",prop:"Quantity"}},[r("el-input",{attrs:{id:"Quantity"},model:{value:e.form.Quantity,callback:function(t){e.$set(e.form,"Quantity",t)},expression:"form.Quantity"}})],1),e._v(" "),r("el-form-item",{attrs:{label:"Price ($)",prop:"Price"}},[r("el-input",{attrs:{id:"Price"},model:{value:e.form.Price,callback:function(t){e.$set(e.form,"Price",t)},expression:"form.Price"}})],1),e._v(" "),r("el-form-item",[r("el-button",{attrs:{type:"primary"},on:{click:e.onSubmit}},[e._v("Save")]),e._v(" "),r("el-button",{on:{click:function(t){return e.$router.push("/manage-products")}}},[e._v("Cancel")])],1)],1)],1)},se=[],ue={render:le,staticRenderFns:se},ce=ue,de=r("VU/8"),me=de(oe,ce,!1,null,null,null),fe=me.exports,pe={name:"manageProducts",data:function(){return{items:[],search:"",loading:!0}},methods:{getAll:function(){var e=this;e.$store.state.services.productService.getAll().then(function(t){e.loading=!1,e.items=t.data}).catch(function(t){console.log(t),e.loading=!1})},handleDelete:function(e){function t(){r.$store.state.services.productService.remove(e).then(function(e){r.loading=!1,r.getAll()}).catch(function(e){r.$message({message:"Ocurrió un error inesperado",type:"error"})})}var r=this;r.$confirm("Esta seguro de realizar esta acción?","Confirmación",{confirmButtonText:"Si",cancelButtonText:"Cancelar",type:"warning"}).then(function(){t()}).catch(function(){})}},created:function(){this.getAll()}},ve=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("div",{staticClass:"custom-container"},[r("h2",{staticClass:"page-tittle"},[e._v("Product List")]),e._v(" "),r("el-table",{staticStyle:{width:"100%"},attrs:{data:e.items.filter(function(t){return!e.search||t.productName.toLowerCase().includes(e.search.toLowerCase())})}},[r("el-table-column",{attrs:{label:"Product Name",prop:"productName",sortable:""}}),e._v(" "),r("el-table-column",{attrs:{label:"Quantity",prop:"quantity"}}),e._v(" "),r("el-table-column",{attrs:{label:"Price",prop:"price"}}),e._v(" "),r("el-table-column",{attrs:{align:"right"},scopedSlots:e._u([{key:"header",fn:function(t){return[r("el-input",{attrs:{size:"mini",placeholder:"Type to search"},model:{value:e.search,callback:function(t){e.search=t},expression:"search"}})]}},{key:"default",fn:function(t){return[r("el-button",{attrs:{size:"mini"},on:{click:function(r){return e.$router.push("/products/"+t.row.id+"/edit")}}},[e._v("Edit")]),e._v(" "),r("el-button",{attrs:{size:"mini",type:"danger"},on:{click:function(r){return e.handleDelete(t.row.id)}}},[e._v("Delete")])]}}])})],1)],1)},he=[],ge={render:ve,staticRenderFns:he},_e=ge,be=r("VU/8"),xe=be(pe,_e,!1,null,null,null),ye=xe.exports,Pe={name:"Product",data:function(){return{form:{ProductName:null,Quantity:null,Price:null}}},methods:{getAll:function(){var e=this;e.$store.state.services.productService.getAll(10).then(function(t){e.data=t.data}).catch(function(e){console.log(e)})}},created:function(){selt.getAll()}},we=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("el-container",[r("el-main",[r("el-table",{attrs:{data:e.tableData}},[r("el-table-column",{attrs:{prop:"ProductName",label:"Product Name",width:"140"}}),e._v(" "),r("el-table-column",{attrs:{prop:"Quantity",label:"Quantity",width:"120"}}),e._v(" "),r("el-table-column",{attrs:{prop:"Price",label:"Price"}})],1)],1)],1)},$e=[],Ne={render:we,staticRenderFns:$e},ke=Ne,Ue=r("VU/8"),Se=n,Ee=Ue(Pe,ke,!1,Se,null,null),Ce=Ee.exports,Ae={name:"ExampleIndex",data:function(){return{loading:!1,items:[]}},created:function(){this.getAll()},methods:{getAll:function(){var e=this;e.loading=!0,e.$store.state.services.exampleService.getAll().then(function(t){e.loading=!1,e.items=t.data}).catch(function(e){})}}},Qe=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("div",[r("h2",[e._v("Products")]),e._v(" "),r("div",{directives:[{name:"loading",rawName:"v-loading",value:e.loading,expression:"loading"}]},[r("el-table",{staticStyle:{width:"100%"},attrs:{data:e.items,"default-sort":{prop:"title",order:"ascending"}}},[r("el-table-column",{attrs:{prop:"Id",label:"Product Id",sortable:"",width:"50"}}),e._v(" "),r("el-table-column",{attrs:{prop:"ProductName",label:"Product Name",sortable:""},scopedSlots:e._u([{key:"default",fn:function(t){return[r("a",{attrs:{href:"#/example/"+t.row.id}},[e._v(e._s(t.row.title))])]}}])}),e._v(" "),r("el-table-column",{attrs:{prop:"Quantity",label:"Quantity in stock"}}),e._v(" "),r("el-table-column",{attrs:{prop:"Price",label:"Price"}})],1)],1)])},Te=[],Re={render:Qe,staticRenderFns:Te},qe=Re,Ie=r("VU/8"),Ve=Ie(Ae,qe,!1,null,null,null),Le=Ve.exports,Fe={name:"ExampleView",data:function(){return{loading:!1,model:{}}},created:function(){var e=this;e.get(e.$route.params.id)},methods:{get:function(e){var t=this;t.loading=!0,t.$store.state.services.exampleService.get(e).then(function(e){t.loading=!1,t.model=e.data}).catch(function(e){})}}},Oe=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("div",{directives:[{name:"loading",rawName:"v-loading",value:e.loading,expression:"loading"}]},[r("h2",[e._v(e._s(e.model.title))]),e._v("\n"+e._s(e.model.body)+"\n")])},Be=[],De={render:Oe,staticRenderFns:Be},ze=De,Me=r("VU/8"),We=Me(Fe,ze,!1,null,null,null),He=We.exports;i.default.use(q.a);var je=[{path:"/",name:"Default",component:z},{path:"/user-information",name:"UserInfo",component:Z},{path:"/add-products",name:"AddProducts",component:ie},{path:"/products/:id/edit",name:"EditProducts",component:fe},{path:"/manage-products",name:"ManageProducts",component:ye},{path:"/products",name:"ListProducts",component:Ce},{path:"/example",name:"ExampleIndex",component:Le},{path:"/example/:id",name:"ExampleView",component:He}],Je=new q.a({routes:je}),Ke=r("uUlv"),Xe=r("mtWM"),Ze=r.n(Xe),Ge=r("Zrlr"),Ye=r.n(Ge),et=r("wxAW"),tt=r.n(et),rt=function(){function e(t,r){Ye()(this,e),this.axios=t,this.baseUrl=r}return tt()(e,[{key:"get",value:function(e){var t=this;return t.axios.get(t.baseUrl+"products/"+e)}},{key:"getAll",value:function(){var e=this;return e.axios.get(e.baseUrl+"products")}},{key:"partial",value:function(e,t){var r=this;return r.axios.patch(r.baseUrl+"products/"+e,t)}},{key:"image",value:function(e,t){var r=this;return r.axios.put(r.baseUrl+"/"+e+"/image",t)}},{key:"create",value:function(e){var t=this;return t.axios.post(t.baseUrl+"products",e)}},{key:"remove",value:function(e){var t=this;return t.axios.delete(t.baseUrl+"products/"+e)}}]),e}(),at=rt,nt=function(){function e(t,r){Ye()(this,e),this.axios=t,this.baseUrl=r}return tt()(e,[{key:"get",value:function(e){var t=this;return t.axios.get(t.baseUrl+"users/"+e)}},{key:"refreshClaims",value:function(){window.location.href="/auth/refresh"}}]),e}(),it=nt,ot=r("//Fk"),lt=r.n(ot),st=function(){function e(){Ye()(this,e)}return tt()(e,[{key:"get",value:function(e){var t=new FileReader;return t.readAsDataURL(e),new lt.a(function(r,a){try{t.onload=function(){r({content:t.result.split(",")[1],name:name||e.name,lenght:e.size,contentType:e.type})}}catch(e){a(e)}})}},{key:"refreshClaims",value:function(){window.location.href="/auth/refresh"}}]),e}(),ut=st;Ze.a.defaults.headers.common.Accept="application/json",Ze.a.defaults.headers.common.Authorization="bearer "+user.Token;var ct={productService:new at(Ze.a,window.Api.URL),userService:new it(Ze.a,window.Api.URL),fileService:new ut};i.default.use(Ke.a);var dt={services:ct},mt=new Ke.a.Store({state:dt});r("H0vN");i.default.config.productionTip=!1,i.default.use(l.a,{locale:u.a}),new i.default({el:"#app",router:Je,store:mt,template:"<App/>",components:{App:R}})},OTTb:function(e,t){},eWLW:function(e,t){},tvR6:function(e,t){}},["NHnr"]);
//# sourceMappingURL=app.f4e554f0763909bde55a.js.map