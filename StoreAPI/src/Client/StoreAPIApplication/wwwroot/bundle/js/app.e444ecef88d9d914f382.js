webpackJsonp([1],{H0vN:function(e,t){},NHnr:function(e,t,r){"use strict";function n(e){r("OTTb")}function a(e){r("eWLW")}Object.defineProperty(t,"__esModule",{value:!0});var o=r("7+uW"),i=r("zL8q"),l=r.n(i),s=r("JR9b"),u=r.n(s),c=(r("tvR6"),{name:"TopHeader",data:function(){return{user:window.user}},methods:{goTo:function(e){void 0!==e&&this.$router.push(e)}}}),d=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("el-row",[r("el-col",{attrs:{span:10}},[r("h1",{on:{click:function(t){return e.goTo("/")}}},[e._v("Boutique Party Store")])]),e._v(" "),r("el-col",{staticClass:"text-center",attrs:{span:4}},[r("el-input",{attrs:{placeholder:"Buscar ..","suffix-icon":"fa fa-search"}})],1),e._v(" "),r("el-col",{staticClass:"text-right user-options",staticStyle:{"text-align":"right"},attrs:{span:10}},[r("a",{staticClass:"item",attrs:{href:"#/user-information"}},[r("i",{staticClass:"fa fa-user"}),e._v(" "+e._s(e.user.Email)+"\n    ")]),e._v(" "),r("a",{staticClass:"item",attrs:{href:"#"}},[r("i",{staticClass:"fa fa-sign-out"})])])],1)},m=[],f={render:d,staticRenderFns:m},p=f,v=r("VU/8"),h=n,_=v(c,p,!1,h,null,null),g=_.exports,b={name:"NavegationMenu",data:function(){return{items:[{icon:"dashboard",text:"Dashboard",path:"/"},{icon:"star",text:"Ejemplo",children:[{icon:"list",text:"Listar",path:"/example"}]},{icon:"wrench",text:"Configuration",children:[{icon:"list",text:"Create Products",path:"/add-products"},{icon:"list",text:"Opción 2",path:"/configuration/opcion2"}]}]}},methods:{redirect:function(e){void 0!==e&&this.$router.push(e)}}},x=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("el-menu",{attrs:{"default-active":"0"}},[e._l(e.items,function(t,n){return[void 0!==t.children?r("el-submenu",{attrs:{index:n.toString()}},[r("template",{slot:"title"},[r("i",{class:"fa fa-"+t.icon}),e._v(" "),r("span",[e._v(e._s(t.text))])]),e._v(" "),r("el-menu-item-group",{attrs:{title:"Options"}},e._l(t.children,function(t,a){return r("el-menu-item",{attrs:{index:n.toString()+a},on:{click:function(r){return e.redirect(t.path)}}},[r("i",{class:"fa fa-"+t.icon}),e._v(" "),r("span",[e._v(e._s(t.text))])])}),1)],2):e._e(),e._v(" "),void 0===t.children?r("el-menu-item",{attrs:{index:"2"},on:{click:function(r){return e.redirect(t.path)}}},[r("i",{class:"fa fa-"+t.icon}),e._v(" "),r("span",[e._v(e._s(t.text))])]):e._e()]})],2)},w=[],P={render:x,staticRenderFns:w},y=P,$=r("VU/8"),N=$(b,y,!1,null,null,null),k=N.exports,U={components:{topheader:g,navegationmenu:k},props:{source:String}},A=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("el-container",[r("el-header",{attrs:{id:"header"}},[r("topheader")],1),e._v(" "),r("el-container",[r("el-aside",{staticStyle:{width:"240px"}},[r("navegationmenu")],1),e._v(" "),r("el-container",[r("el-main",[r("el-row",[r("el-col",{attrs:{span:24}},[r("router-view")],1)],1)],1),e._v(" "),r("el-footer",[e._v("© "),r("a",{attrs:{target:"_blank",href:"http://anexsoft.com/p/186/proyecto-base-spa-con-vue-vuex-vuerouter-axios-y-element-ui"}},[e._v(e._s("Desarrollo por Anexsoft "+(new Date).getFullYear()))])])],1)],1)],1)},E=[],S={render:A,staticRenderFns:E},R=S,V=r("VU/8"),C=V(U,R,!1,null,null,null),Q=C.exports,T=r("/ocq"),q={name:"Default"},F=function(){var e=this,t=e.$createElement;e._self._c;return e._m(0)},L=[function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("div",[r("h2",[e._v("Dashboard")]),e._v(" "),r("p",[e._v("La siguiente aplicación contiene:")]),e._v(" "),r("ul",[r("li",[r("b",[e._v("Vue")]),e._v(": nuestro framework para crear componentes")]),e._v(" "),r("li",[r("b",[e._v("Vuex")]),e._v(": para compartir recursos entre toda la aplicación.")]),e._v(" "),r("li",[r("b",[e._v("VueRouter")]),e._v(": para generar un router que nos permita navegar por las URL.")]),e._v(" "),r("li",[r("b",[e._v("Axios")]),e._v(": para trabajar las peticiones AJAX.")]),e._v(" "),r("li",[r("b",[e._v("Element Ui")]),e._v(": como bootstrap pero hecho y pensando para Vue.")])]),e._v(" "),r("p",[e._v("Proyecto base desarrollado por Anexsoft. Para visualizar un módulo desarrollado ingresa al menú de Ejemplo.")])])}],I={render:F,staticRenderFns:L},D=I,W=r("VU/8"),O=W(q,D,!1,null,null,null),j=O.exports,H={name:"Information",created:function(){this.get()},data:function(){return{form:{userName:null,email:null}}},methods:{get:function(){var e=this;e.$store.state.services.userService.get(window.user.UserId).then(function(t){e.form=t.data}).catch(function(e){console.log(e)})}}},J=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("el-container",[r("el-form",{ref:"form",attrs:{model:e.form,"label-width":"120px"}},[r("h2",{staticClass:"page-title"},[e._v("Personal Information")]),e._v(" "),r("el-form-item",{attrs:{label:"User Name"}},[r("el-input",{attrs:{readonly:!0},model:{value:e.form.userName,callback:function(t){e.$set(e.form,"userName",t)},expression:"form.userName"}})],1),e._v(" "),r("el-form-item",{attrs:{label:"Email"}},[r("el-input",{attrs:{readonly:!0},model:{value:e.form.email,callback:function(t){e.$set(e.form,"email",t)},expression:"form.email"}})],1)],1)],1)},z=[],M={render:J,staticRenderFns:z},B=M,X=r("VU/8"),Y=X(H,B,!1,null,null,null),Z=Y.exports,G={name:"createProducts",data:function(){return{rules:{ProductName:[{required:!0,message:"This field is required",trigger:"blur"},{min:3,max:25,message:"Length must be 3 to 25 characters",trigger:"blur"}],Quantity:[{required:!0,message:"This field is required",trigger:"blur"}],Price:[{required:!0,message:"This field is required",trigger:"blur"}]},form:{ProductName:null,Quantity:null,Price:null}}},methods:{onSubmit:function(){var e=this;console.log(e.form)},get:function(){this.$store.state.services.productService.get()}}},K=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("el-container",[r("el-form",{ref:"form",attrs:{model:e.form,rules:e.rules,"label-width":"120px"}},[r("h2",[e._v("Create a new Product")]),e._v(" "),r("el-form-item",{attrs:{label:"Product Name",prop:"ProductName"}},[r("el-input",{model:{value:e.form.ProductName,callback:function(t){e.$set(e.form,"ProductName",t)},expression:"form.ProductName"}})],1),e._v(" "),r("el-form-item",{attrs:{label:"Quantity",prop:"Quantity"}},[r("el-input",{model:{value:e.form.Quantity,callback:function(t){e.$set(e.form,"Quantity",t)},expression:"form.Quantity"}})],1),e._v(" "),r("el-form-item",{attrs:{label:"Price ($)",prop:"Price"}},[r("el-input",{model:{value:e.form.Price,callback:function(t){e.$set(e.form,"Price",t)},expression:"form.Price"}})],1),e._v(" "),r("el-form-item",[r("el-button",{attrs:{type:"primary"},on:{click:e.onSubmit}},[e._v("Create")]),e._v(" "),r("el-button",{on:{click:function(t){return e.$router.push("/")}}},[e._v("Cancel")])],1)],1)],1)},ee=[],te={render:K,staticRenderFns:ee},re=te,ne=r("VU/8"),ae=ne(G,re,!1,null,null,null),oe=ae.exports,ie={name:"Product",data:function(){return{form:{ProductName:null,Quantity:null,Price:null}}},methods:{getAll:function(){var e=this;e.$store.state.services.productService.getAll(10).then(function(t){e.data=t.data}).catch(function(e){console.log(e)})}},created:function(){selt.getAll()}},le=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("el-container",[r("el-main",[r("el-table",{attrs:{data:e.tableData}},[r("el-table-column",{attrs:{prop:"ProductName",label:"Product Name",width:"140"}}),e._v(" "),r("el-table-column",{attrs:{prop:"Quantity",label:"Quantity",width:"120"}}),e._v(" "),r("el-table-column",{attrs:{prop:"Price",label:"Price"}})],1)],1)],1)},se=[],ue={render:le,staticRenderFns:se},ce=ue,de=r("VU/8"),me=a,fe=de(ie,ce,!1,me,null,null),pe=fe.exports,ve={name:"ExampleIndex",data:function(){return{loading:!1,items:[]}},created:function(){this.getAll()},methods:{getAll:function(){var e=this;e.loading=!0,e.$store.state.services.exampleService.getAll().then(function(t){e.loading=!1,e.items=t.data}).catch(function(e){})}}},he=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("div",[r("h2",[e._v("Products")]),e._v(" "),r("div",{directives:[{name:"loading",rawName:"v-loading",value:e.loading,expression:"loading"}]},[r("el-table",{staticStyle:{width:"100%"},attrs:{data:e.items,"default-sort":{prop:"title",order:"ascending"}}},[r("el-table-column",{attrs:{prop:"Id",label:"Product Id",sortable:"",width:"50"}}),e._v(" "),r("el-table-column",{attrs:{prop:"ProductName",label:"Product Name",sortable:""},scopedSlots:e._u([{key:"default",fn:function(t){return[r("a",{attrs:{href:"#/example/"+t.row.id}},[e._v(e._s(t.row.title))])]}}])}),e._v(" "),r("el-table-column",{attrs:{prop:"Quantity",label:"Quantity in stock"}}),e._v(" "),r("el-table-column",{attrs:{prop:"Price",label:"Price"}})],1)],1)])},_e=[],ge={render:he,staticRenderFns:_e},be=ge,xe=r("VU/8"),we=xe(ve,be,!1,null,null,null),Pe=we.exports,ye={name:"ExampleView",data:function(){return{loading:!1,model:{}}},created:function(){var e=this;e.get(e.$route.params.id)},methods:{get:function(e){var t=this;t.loading=!0,t.$store.state.services.exampleService.get(e).then(function(e){t.loading=!1,t.model=e.data}).catch(function(e){})}}},$e=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("div",{directives:[{name:"loading",rawName:"v-loading",value:e.loading,expression:"loading"}]},[r("h2",[e._v(e._s(e.model.title))]),e._v("\n"+e._s(e.model.body)+"\n")])},Ne=[],ke={render:$e,staticRenderFns:Ne},Ue=ke,Ae=r("VU/8"),Ee=Ae(ye,Ue,!1,null,null,null),Se=Ee.exports;o.default.use(T.a);var Re=[{path:"/",name:"Default",component:j},{path:"/user-information",name:"UserInfo",component:Z},{path:"/add-products",name:"AddProducts",component:oe},{path:"/products",name:"ListProducts",component:pe},{path:"/example",name:"ExampleIndex",component:Pe},{path:"/example/:id",name:"ExampleView",component:Se}],Ve=new T.a({routes:Re}),Ce=r("uUlv"),Qe=r("mtWM"),Te=r.n(Qe),qe=r("Zrlr"),Fe=r.n(qe),Le=r("wxAW"),Ie=r.n(Le),De=function(){function e(t,r){Fe()(this,e),this.axios=t,this.baseUrl=r}return Ie()(e,[{key:"get",value:function(e){var t=this;return t.axios.get(t.baseUrl+"products/"+e)}},{key:"getAll",value:function(e,t){var r=this;return r.axios.get(r.baseUrl+"products?take=${take}&filter=${JSON.stringify(filter)}")}}]),e}(),We=De,Oe=function(){function e(t,r){Fe()(this,e),this.axios=t,this.baseUrl=r}return Ie()(e,[{key:"get",value:function(e){var t=this;return t.axios.get(t.baseUrl+"users/"+e)}},{key:"refreshClaims",value:function(){window.location.href="/auth/refresh"}}]),e}(),je=Oe;Te.a.defaults.headers.common.Accept="application/json",Te.a.defaults.headers.common.Authorization="bearer ${user.Token}";var He={productService:new We(Te.a,window.Api.URL),userService:new je(Te.a,window.Api.URL)};o.default.use(Ce.a);var Je={services:He},ze=new Ce.a.Store({state:Je});r("H0vN");o.default.config.productionTip=!1,o.default.use(l.a,{locale:u.a}),new o.default({el:"#app",router:Ve,store:ze,template:"<App/>",components:{App:Q}})},OTTb:function(e,t){},eWLW:function(e,t){},tvR6:function(e,t){}},["NHnr"]);
//# sourceMappingURL=app.e444ecef88d9d914f382.js.map