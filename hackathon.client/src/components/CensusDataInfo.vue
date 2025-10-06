<template>
  <div>
    <p>
      There is some basic Census Data stored in <v-chip>Census Data</v-chip> with fields like the total population, number of households, businesses, and median income for a given zipcode. Additionally Census data on poverty and food assistance for each zipcode has also been included in a variety of tables. 
    </p>
    <p>
      Most of the census database tables follow a pattern of providing a total value for the given metric and then a percentage of a target population that total makes up. The percentages are typically already a subset (i.e. PercentBelowPovertyLevelAGEUnder5Years is the percent (BelowPovertyAGEUnder5Years/TotalAGEUnder5Years) not the % of the total population that is below poverty level and under 5 years old.) 
    </p>
    <p>
      The original Census data files are multi-layered, a section of rows will have their own hirearchy where subsequent rows are subsets of a heading row. As such, in the database you will find tables with the raw census files as well as a number of tables that has turned the values into numeric data types and attempted to flatten them. 
    </p>
    <p>
      <v-chip>RawCensusDataFoodAssistance</v-chip> and <v-chip>RawCensusDataPoverty</v-chip> contain the original csv exports from the census website. 
    </p>
    <p>
      <v-chip>CensusFoodAssistanceData</v-chip> and <v-chip>CensusPovertyData</v-chip> contain a flattened version of those csv files. There are many columns.
    </p>
    <p>
      The other CensusFoodAssistance and CensusPoverty tables have a smaller number of columns in the previous tables in attempt to help you work with some smaller subsets of data. 
    </p>
    <p>
      Since the government is currently in a shut down and the Census data is not consistently available, <a href="https://drive.google.com/drive/folders/1PA5Oh5-YO6qfTyqfZbU7s3a_P-r_RZwH?usp=sharing" target="_blank">here is a link to the original files downloaded from Census reports.</a> 
    </p>
  </div>
</template>

<script lang="js">
  import { defineComponent } from 'vue';

  export default defineComponent({
    data() {
      return {
        panel: null
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
  p {
    margin-bottom: 16px;
  }
</style>