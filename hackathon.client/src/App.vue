<template>
  <v-app>
    <v-layout>
      <v-main>
        <v-tabs
          v-model="tab"
          bg-color="primary"
        >
          <v-tab value="info">Info</v-tab>
          <v-tab value="api">API</v-tab>
          <v-tab value="connect">Database Info</v-tab>
        </v-tabs>
        <v-container>
          <v-tabs-window v-model="tab">
            <v-tabs-window-item value="info">
              <v-home></v-home>
            </v-tabs-window-item>
            <v-tabs-window-item value="api">
              <v-api></v-api>
            </v-tabs-window-item>
            <v-tabs-window-item value="connect">
              <v-container>
                <v-card :elevation="2">
                  <v-card-text>
                    Here's a read only user, everything's pretty open. Please don't try to crash the server. <br/> <br/>
                    server: @citndbserver.database.windows.net <br/>
                    un: citnuser <br/>
                    pw: QVufoap4Rp3Whtm <br/><br/>
                    Want your own instance of the data? Shoot your shot with a download or ask for a flash drive<br/>
                    <a href="https://drive.google.com/file/d/1vAlKs1Z_V0qLIA7ewbmPq5SN4aBA-96m/view" target="_blank">link</a>
                  </v-card-text>
                </v-card>
              </v-container>
            </v-tabs-window-item>
          </v-tabs-window>
        </v-container>
      </v-main>
    </v-layout>
  </v-app>
</template>

<script>
import API from './components/API.vue'
import Home from './components/Home.vue';
export default {
  components: {
    'v-api': API,
    'v-home': Home
  },
  data: () => ({
    tab: null,
  }),
  mounted() {
    fetch('/api/CensusData').then(r => { console.log(r); console.log(r.json()) })
  }
}
</script>

<style>
#app {
  width: 100%;
  padding: 0px !important;
  margin: 0px !important;
  display: block !important;
  max-width: 100% !important;
}
</style>
