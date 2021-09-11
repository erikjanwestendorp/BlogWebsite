module.exports = {
    transpileDependencies: [],
    runtimeCompiler: true,
    productionSourceMap: false,
    filenameHashing: false,
    publicPath: process.env.NODE_ENV === 'production' ? '/Assets/' : '/',
    pages: {
      index: {
        entry: 'src/main.ts',
        template: 'public/index.html',
        minify: false
      },
      blokken:{
        entry: 'src/main.ts',
        template: 'public/blokken.html',
        minify: false
      }
    },
    chainWebpack: config => {
      config.module
        .rule('svg-sprite')
        .use('svgo-loader')
        .loader('svgo-loader');
      config.module
        .rule('nunjucks')
        .test(/\.(html|njk|nunjucks)$/)
        .use('simple-nunjucks-loader')
        .tap(options => {
          options = {
            tags: {
              variableStart: '{@',
              variableEnd: '@}'
            }
          };
          return options;
        })
        .loader('simple-nunjucks-loader');
    },
    pluginOptions: {
      svgSprite: {
        dir: 'src/assets/images/sprite',
        test: /\.(svg)(\?.*)?$/,
        /*
         * @see https://github.com/kisenka/svg-sprite-loader#configuration
         */
        loaderOptions: {
          extract: true,
          spriteFilename: 'img/icon-sprite.svg'
        },
        pluginOptions: {
          plainSprite: false
        }
      }
    },
    css: {
      loaderOptions: {
        sass: {
          additionalData: `@import "@/assets/scss/index.scss";`
        }
      }
    }
  }