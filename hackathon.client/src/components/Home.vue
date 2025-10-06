<template>
  <v-expansion-panels v-model="panel">
    <v-expansion-panel>
      <v-expansion-panel-title>Font-End Prompt: Ministry Resource Map/Web Page</v-expansion-panel-title>
      <v-expansion-panel-text>
        Cincinnati is a big place with a lot of people. Build a web page to help people get connected to different resources. 
      </v-expansion-panel-text>
    </v-expansion-panel>
    <v-expansion-panel>
      <v-expansion-panel-title>Back-End Prompt: Data Analysis</v-expansion-panel-title>
      <v-expansion-panel-text>
        There's an API endpoint with resources in Cincinnati. There's a lot of endpoints with various Census data based on zipcode. Can you suggest an area of Cincinnati that is missing certain resources? Build a dashboard with information to help the staff at Crossroads minister to the people in their community? 
      </v-expansion-panel-text>
    </v-expansion-panel>
    <v-expansion-panel>
      <v-expansion-panel-title>Census Data 101</v-expansion-panel-title>
      <v-expansion-panel-text>
        <census-data></census-data>
      </v-expansion-panel-text>
    </v-expansion-panel>
  </v-expansion-panels>
</template>

<script lang="js">
  import CensusDataInfo from './CensusDataInfo.vue';
  import { defineComponent } from 'vue';

  export default defineComponent({
    components: {
      'census-data': CensusDataInfo
    },
    data() {
      return {
        panel: [2]
      };
    },
    created() {
        
    },
    watch: {
        
    },
    methods: {
        
    },
  });
</script>

<style scoped>

</style>