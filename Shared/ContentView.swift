//
//  ContentView.swift
//  Shared
//
//  Created by Torsten Wehrhahn on 02.07.20.
//

import SwiftUI

struct ContentView: View {
    @State var data = 0
    var body: some View {
        Text("Hello, world! - \(data)").font(.largeTitle).padding()
            .onTapGesture {
                data+=1
            }
    }
}

struct ContentView_Previews: PreviewProvider {
    static var previews: some View {
        Group {
            ContentView(data:55)
            ContentView(data:48)
                .preferredColorScheme(.dark)
        }
    }
}
