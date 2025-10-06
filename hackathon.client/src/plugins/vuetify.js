import 'vuetify/styles'
import { createVuetify } from 'vuetify'
import * as components from 'vuetify/components'
import * as directives from 'vuetify/directives'
import colors from 'vuetify/util/colors'

const vuetify = createVuetify({
  components,
  directives,
  theme: {
    themes: {
      light: {
        dark: false,
        colors: {
          primary: colors.indigo.darken3,
          secondary: colors.blue.lighten1, 
        }
      },
    },
  },
  // You can add global configuration here, e.g., theme, icons
  // theme: {
  //   defaultTheme: 'light',
  // },
  // icons: {
  //   iconfont: 'mdi', // 'mdi' or 'fa' or 'md'
  // },
})

export default vuetify