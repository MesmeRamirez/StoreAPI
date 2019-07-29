<template>
  <el-container>
    <el-header id="header">
      <topheader></topheader>
    </el-header>
    <el-container>
      <el-aside style="width:240px;">
        <navegationmenu></navegationmenu>
      </el-aside>
      <el-container>
        <el-main>
          <el-row>
            <el-col :span="24">
              <router-view></router-view>
            </el-col>
          </el-row>
        </el-main>
        <el-footer></el-footer>
      </el-container>
    </el-container>
  </el-container>
</template>

<script>
import topheader from "@/components/shared/TopHeader"
import navegationmenu from "@/components/shared/NavegationMenu";

export default {
  components: {
    topheader, navegationmenu
  },
  props: {
    source: String
  }
};
</script>
